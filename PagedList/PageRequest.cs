namespace JsonPagedList
{
    /// <summary>
    /// Page request
    /// </summary>
    public class PageRequest : IPageRequest
    {
        /// <summary>
        /// Index
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        public int Size { get; set; }
    }
}
