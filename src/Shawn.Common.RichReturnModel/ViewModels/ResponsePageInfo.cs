using System.ComponentModel;

namespace Shawn.Common.RichReturnModel
{
    /// <inheritdoc />
    public class ResponsePageInfo : IResponsePageInfo
    {
        public ResponsePageInfo(int page, int pageSize, int totalCount)
        {
            this.page = page;
            this.pageSize = pageSize;
            this.totalCount = totalCount;
        }

        /// <inheritdoc />
        [DefaultValue(1)]
        public int page { get; set; }

        /// <inheritdoc />
        [DefaultValue(20)]
        public int pageSize { get; set; }

        /// <inheritdoc />
        public int totalCount { get; set; }

        /// <inheritdoc />
        public int pageCount => (totalCount + pageSize - 1) / pageSize;

    }
}