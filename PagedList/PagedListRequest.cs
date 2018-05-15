namespace JsonPagedList
{
    /// <summary>
    ///     Page request
    /// </summary>
    public class PagedListRequest : IPageRequest
    {
        /// <summary>
        ///     Ctor
        /// </summary>
        public PagedListRequest()
        {

        }

        /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="index"></param>
        /// <param name="size"></param>
        public PagedListRequest(int index, int size)
        {
            Index = index;
            Size = size;
        }

        /// <summary>
        ///     Index
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        ///     Size
        /// </summary>
        public int Size { get; set; }
    }
}