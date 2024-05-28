namespace Fina.Core.Requests
{
    public abstract class PagedRequest : Request
    {
        public int PageSize { get; set; } = Configuration.DefaltPageSize;
        public int PageNumber { get; set; } = Configuration.DefaltPageNumber;
    }
}
