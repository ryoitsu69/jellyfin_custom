using System;

namespace Jellyfin.Api.Models.ShareDtos
{
    /// <summary>
    /// Share response dto.
    /// </summary>
    public class ShareResponse
    {
        /// <summary>
        /// Gets or sets the share URL.
        /// </summary>
        public string ShareUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the item name.
        /// </summary>
        public string ItemName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the item id.
        /// </summary>
        public Guid ItemId { get; set; }

        /// <summary>
        /// Gets or sets the date when the item was shared.
        /// </summary>
        public DateTime SharedDate { get; set; }

        /// <summary>
        /// Gets or sets the expiration date for the share.
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets the username of the user who shared the item.
        /// </summary>
        public string SharedBy { get; set; } = string.Empty;
    }
}
