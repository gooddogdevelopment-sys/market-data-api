using System.ComponentModel.DataAnnotations;

namespace dotnet_core_api_w_postgres.Models;

public class Watchlist : BaseEntity
{
    [MaxLength(50)]
    public required string Name { get; set; }

    public ICollection<WatchlistItem> Items { get; set; } = new List<WatchlistItem>();
}
