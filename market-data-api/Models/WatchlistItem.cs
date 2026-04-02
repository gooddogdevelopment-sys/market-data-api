using System.ComponentModel.DataAnnotations;

namespace dotnet_core_api_w_postgres.Models;

public class WatchlistItem : BaseEntity
{
    [MaxLength(10)]
    public required string Symbol { get; set; }

    public int WatchlistId { get; set; }
    public Watchlist Watchlist { get; set; }
}
