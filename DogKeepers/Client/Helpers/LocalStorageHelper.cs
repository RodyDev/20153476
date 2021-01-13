using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace DogKeepers.Client.Helpers
{
    public class LocalStorageHelper
    {
        
        private readonly IJSRuntime _jsRuntime;
        private readonly LocalStorageMethods _localStorageMethods;
        
        private struct LocalStorageMethods
        {
            public string Set => "setLocalStorageValue";
            public string Get => "getLocalStorageValue";
            public string Remove => "removeLocalStorageValue";
        }

        public LocalStorageHelper(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }

        public async Task SetValue(string key, string value){
            await _jsRuntime.InvokeVoidAsync(_localStorageMethods.Set, key, value);
        }

        public async Task<string> GetValue(string key){
            var value = await _jsRuntime.InvokeAsync<string>(_localStorageMethods.Get, key);
            
            return value;
        }

        public async Task RemoveValue(string key){
            await _jsRuntime.InvokeVoidAsync(_localStorageMethods.Remove, key);
        }
    }
}