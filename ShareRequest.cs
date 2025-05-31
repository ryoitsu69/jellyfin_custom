using System;

namespace Jellyfin.Api.Models.ShareDtos
{
    /// <summary>
    /// Share request dto.
    /// </summary>
    public class ShareRequest
    {
        /// <summary>
        /// Gets or sets the expiration date for the share.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }
    }
}
