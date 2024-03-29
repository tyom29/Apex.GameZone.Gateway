﻿namespace Apex.GameZone.Core.Models;

public class CheckoutModel : BaseModel
{
    public int GameZoneId { get; set; }
    public int SectionId { get; set; }
    public DateTime Start { get; set; }
    public DateTime? ExpectedEnd { get; set; }
    public DateTime? End { get; set; }
    public int Bill { get; set; }

    public ICollection<ItemCheckoutModel> ConnectedItems { get; set; }
    public ICollection<ProductCheckoutModel> ConnectedProducts { get; set; }
}