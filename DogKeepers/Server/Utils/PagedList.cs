using System;
using System.Collections.Generic;

namespace DogKeepers.Server.Utils
{
    public class PagedList<T> : List<T>
    {

        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }

        public bool HasNextPage => CurrentPage < TotalPages;
        public bool HasPreviousPage => CurrentPage > 1;

        public int? NextPageNumber => HasNextPage ? CurrentPage + 1 : (int?) null;
        public int? PreviousPageNumber => HasPreviousPage ? CurrentPage - 1 : (int?) null;


        public PagedList(List<T> items, int currentPage, int pageSize, int totalCount)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalCount = totalCount;
            TotalPages = (int)Math.Ceiling(totalCount / (double)PageSize );

            AddRange(items);
        }

        public static PagedList<T> Create(List<T> source, int currentPage, int pageSize, int totalCount)
        {
            return new PagedList<T>(source, currentPage, pageSize, totalCount);
        }
    }
}