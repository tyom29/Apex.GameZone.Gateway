﻿using Apex.GameZone.Shared.Enums;

namespace Apex.GameZone.Core.Models;

public class SectionModel : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DeviceTypes Type { get; set; }
    public int PricePerHour { get; set; }
    public bool IsVip { get; set; }
    public bool IsBusy { get; set; }
    public int GameZoneId { get; set; }
}