using System;

namespace Jellyfin.Api.Models.ShareDtos
{
    /// <summary>
    /// Active share DTO.
    /// </summary>
    public class ActiveShareDto
    {
        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the item name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the item type display name.
        /// </summary>
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the share expiration date.
        /// </summary>
        public DateTime ShareUntil { get; set; }

        /// <summary>
        /// Gets or sets the item image URL.
        /// </summary>
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the parent album ID (for songs).
        /// </summary>
        public Guid? AlbumId { get; set; }

        /// <summary>
        /// Gets or sets the parent album name (for songs).
        /// </summary>
        public string? AlbumName { get; set; }

        /// <summary>
        /// Gets or sets the parent artist ID (for songs and albums).
        /// </summary>
        public Guid? ArtistId { get; set; }

        /// <summary>
        /// Gets or sets the parent artist name (for songs and albums).
        /// </summary>
        public string? ArtistName { get; set; }
    }
}
