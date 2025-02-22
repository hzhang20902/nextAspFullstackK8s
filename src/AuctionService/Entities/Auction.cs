﻿//namespace doesn't require the .Entities in later versions but keeps folder org more visually intact
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http.Features;

namespace AuctionService.Entities;

public class Auction
{
    public Guid Id { get; set;}

    public int ReservePrice { get; set; } = 0;

    public string Seller { get; set;}
    public string Winner { get; set;}
    public int? SoldAmount { get; set;}
    public int? CurrentHighBid {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.UtcNow;

    public DateTime UpdatedAt {get;set;} = DateTime.UtcNow;
    public DateTime AuctionEnd {get;set;}

    public Status Status {get;set;}
    public Item Item {get;set;}
}
