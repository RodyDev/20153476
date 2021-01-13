using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using DogKeepers.Client.Helpers;
using DogKeepers.Client.Interfaces;
using DogKeepers.Client.Options;
using DogKeepers.Shared.ApiResponses;
using DogKeepers.Shared.DTOs;
using Microsoft.AspNetCore.Components.Authorization;

namespace DogKeepers.Client.Providers
{
    public class JwtProvider : AuthenticationStateProvider, IJwtProvider
    {

        private readonly HttpClient _httpClient;
        private readonly LocalStorageHelper _localStorageHelper;
        private readonly LocalStorageOption _localStorageOption;
        private AuthenticationState _anonymous => new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

        public JwtProvider(
            HttpClient httpClient,
            LocalStorageOption localStorageOption,
            LocalStorageHelper localStorageHelper
        )
        {
            _httpClient = httpClient;
            _localStorageOption = localStorageOption;
            _localStorageHelper = localStorageHelper;
        }

        public async Task Login(JwtDto token)
        {
            await _localStorageHelper.SetValue(_localStorageOption.Token, token.Token);
            await _localStorageHelper.SetValue(_localStorageOption.Expiration, token.ExpirationDate.ToString());

            var authState = CreateAuthenticationState(token.Token);

            NotifyAuthenticationStateChanged(Task.FromResult(authState));
        }

        public async Task Logout()
        {
            await CleanJwtStorage();
            NotifyAuthenticationStateChanged(Task.FromResult(_anonymous));
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var jwt = await _localStorageHelper.GetValue(_localStorageOption.Token);

            if (string.IsNullOrEmpty(jwt))
            {
                return _anonymous;
            }

            DateTime expirationTime;
            var expirationTimeString = await _localStorageHelper.GetValue(_localStorageOption.Expiration);

            if (DateTime.TryParse(expirationTimeString, out expirationTime))
            {
                if (IsExpiredToken(expirationTime))
                {
                    await CleanJwtStorage();
                    return _anonymous;
                }

                if (IsRequiredRefreshToken(expirationTime))
                {
                    var token = await RefreshToken(jwt);

                    if (String.IsNullOrEmpty(token))
                    {
                        return _anonymous;
                    }
                    else
                    {
                        jwt = token;
                    }
                }
            }

            return CreateAuthenticationState(jwt);
        }

        public async Task TaskVerifyRefreshToken()
        {
            DateTime expirationTime;
            var expirationTimeString = await _localStorageHelper.GetValue(_localStorageOption.Expiration);

            if (DateTime.TryParse(expirationTimeString, out expirationTime))
            {
                if (IsExpiredToken(expirationTime))
                {
                    await Logout();
                }

                if (IsRequiredRefreshToken(expirationTime))
                {
                    var jwt = await _localStorageHelper.GetValue(_localStorageOption.Token);
                    var newJwt = await RefreshToken(jwt);

                    if (String.IsNullOrEmpty(newJwt))
                    {
                        await Logout();
                    }
                    else
                    {
                        var authState = CreateAuthenticationState(newJwt);
                        NotifyAuthenticationStateChanged(Task.FromResult(authState));
                    }
                }
            }
        }

        private async Task<string> RefreshToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);

            var apiResponse =
                await
                _httpClient.GetFromJsonAsync<ApiResponse<JwtDto>>(
                    $"Auth/"
                );

            if (apiResponse.Errors != null)
            {
                return null;
            }
            else
            {
                await _localStorageHelper.SetValue(_localStorageOption.Token, apiResponse.Data.Token);
                await _localStorageHelper.SetValue(_localStorageOption.Expiration, apiResponse.Data.ExpirationDate.ToString());

                return apiResponse.Data.Token;
            }
        }

        private bool IsRequiredRefreshToken(DateTime expirationTime)
        {
            return expirationTime.Subtract(DateTime.Now) < TimeSpan.FromMinutes((int)_localStorageOption.MinutesLeftToRefresh);
        }

        private bool IsExpiredToken(DateTime expirationTime)
        {
            return expirationTime <= DateTime.Now;
        }

        private async Task CleanJwtStorage()
        {
            await _localStorageHelper.RemoveValue(_localStorageOption.Token);
            await _localStorageHelper.RemoveValue(_localStorageOption.Expiration);

            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public AuthenticationState CreateAuthenticationState(string token)
        {

            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("bearer", token);
            var claims = ParseClaimsFromJwt(token);
            var user = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(claims, "JWT")));

            return user;
        }

        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);

            if (roles != null)
            {
                if (roles.ToString().Trim().StartsWith("["))
                {
                    var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());

                    foreach (var parsedRole in parsedRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                    }
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
                }

                keyValuePairs.Remove(ClaimTypes.Role);
            }

            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));

            return claims;
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }




    }
}