namespace WorldNewsApp.Models.Pageing
{
    public class PageingList<T> : List<T>
    {
        public PageingList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public int PageIndex { get; init; }

        public int TotalPages { get; init; }

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;
    }
}
