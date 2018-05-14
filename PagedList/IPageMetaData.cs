namespace JsonPagedList
{
    public interface IPageMetaData
    {
        /// <summary>
        ///     page size
        /// </summary>
        int PageSize { get; set; }

        /// <summary>
        ///     total count
        /// </summary>
        int TotalCount { get; set; }

        /// <summary>
        ///     total page
        /// </summary>
        int TotalPages { get; set; }

        /// <summary>
        ///     Min page
        /// </summary>
        int MinDataPage { get; }

        /// <summary>
        /// </summary>
        int MaxDataPage { get; }

        /// <summary>
        ///     has pervious page
        /// </summary>
        bool HasPreviousPage { get; }

        /// <summary>
        ///     has next page
        /// </summary>
        bool HasNextPage { get; }
    }
}