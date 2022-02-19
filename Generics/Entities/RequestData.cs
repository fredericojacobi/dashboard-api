using System;
using System.Collections.Generic;
using System.Linq;
using Generics.Functions;

namespace Generics.Entities
{
    public class RequestData<T> where T : class
    {
        private IEnumerable<T>? _records { get; set; }
        private int? _recordsPerPage { get; set; }
        public bool Result => _records != null && _records.Any();
        public IEnumerable<T>? Records => Pagination<T>.GetRecords(_records, CurrentPage, RecordsPerPage);
        public Exception Exception { get; set; }
        public string Message { get; set; }
        public int RecordsPerPage => _recordsPerPage ?? 1;
        public int TotalPages => Pagination<T>.SetTotalPages(TotalRecords, RecordsPerPage);
        public int TotalRecords => _records?.Count() ?? 0;
        public int PreviousPage => CurrentPage > 1 ? CurrentPage - 1 : CurrentPage;
        public int CurrentPage { get; set; }
        public int NextPage => TotalPages == CurrentPage ? CurrentPage : CurrentPage + 1;
        public bool HasNext => CurrentPage < TotalPages;
        public bool HasPrevious => CurrentPage > 1;

        public RequestData()
        {
            CurrentPage = 1;
        }

        public RequestData(T record)
        {
            CurrentPage = 1;
            _records = new List<T> {record};
        }

        public RequestData(Exception exception)
        {
            CurrentPage = 1;
            Exception = exception;
        }

        public RequestData(IEnumerable<T> records)
        {
            CurrentPage = 1;
            _records = records;
        }

        public RequestData(IEnumerable<T> records, int currentPage, int recordsPerPage)
        {
            _records = records;
            CurrentPage = currentPage;
            _recordsPerPage = recordsPerPage;
        }
    }
}