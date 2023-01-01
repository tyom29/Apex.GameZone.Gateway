﻿namespace Apex.GameZone.Core.Models;

public class ItemModel : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal PricePerHour { get; set; }
    public int GameZoneId { get; set; }
}