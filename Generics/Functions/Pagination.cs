using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics.Functions
{
    public static class Pagination<T> where T : class
    {
        public static int SetTotalPages(int totalRecords, int recordsPerPage)
        {
            var records = (int) Math.Ceiling((double) totalRecords / recordsPerPage);
            return records < 1 ? 1 : records;
        }

        public static IEnumerable<T> GetRecords(IEnumerable<T> records, int currentPage, int recordsPerPage) =>
            records?.Skip((currentPage - 1) * recordsPerPage).Take(recordsPerPage).ToList();
    }
}