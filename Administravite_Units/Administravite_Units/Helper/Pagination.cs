using Administravite_Units.ViewModel;

namespace Administravite_Units.Helper
{
    public class Pagination<T>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }
        public List<T> Data { get; set; }
        public Pagination(IEnumerable<T> ListData, int page, int pageSize)
        {
            var countData = ListData.Count();
            var totalPage = (int)Math.Ceiling(Convert.ToDouble(countData) / pageSize);
            var pageData = ListData.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            Page = page;
            PageSize = pageSize;
            TotalPage = totalPage;
            Data = pageData;
        }

    }
}
