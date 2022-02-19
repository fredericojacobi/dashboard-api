using System.Collections.Generic;
using Entities.Models.DataTransferObjects;

namespace Entities.Models
{
    public class OrderPagination
    {
        public IEnumerable<OrderDTO>? Records { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public int PreviousPage { get; set; }
        public int CurrentPage { get; set; }
        public int NextPage { get; set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }
        
        public OrderPagination()
        {
        }
    }
}