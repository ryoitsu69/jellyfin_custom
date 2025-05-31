using System;

namespace Jellyfin.Api.Models.ShareDtos
{
    /// <summary>
    /// Share info response dto.
    /// </summary>
    public class ShareInfoResponse
    {
        /// <summary>
        /// Gets or sets the item id.
        /// </summary>
        public Guid ItemId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item is shared.
        /// </summary>
        public bool IsShared { get; set; }

        /// <summary>
        /// Gets or sets the date when the item was shared.
        /// </summary>
        public DateTime? SharedDate { get; set; }

        /// <summary>
        /// Gets or sets the expiration date for the share.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets the username of the user who shared the item.
        /// </summary>
        public string? SharedBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the share has expired.
        /// </summary>
        public bool IsExpired { get; set; }
    }
}
