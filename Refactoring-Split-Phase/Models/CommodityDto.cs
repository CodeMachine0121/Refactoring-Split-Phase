using Refactoring_Split_Phase.Enums;

namespace Refactoring_Split_Phase.Models;

public class CommodityDto
{
    public Weapon Weapon { get; set; }
    public Materials Materials { get; set; }
    public decimal Discount { get; set; }

    public decimal SetPriceByCommodity(decimal totalPrice)
    {
        if (Weapon == Weapon.Sword)
        {
            totalPrice += 30;
        }

        if (Materials.Material == "Wood")
        {
            totalPrice += 20;
            if (Materials.Quality == Quality.Good)
            {
                totalPrice += totalPrice * 0.1m;
            }
        }

        return totalPrice;
    }

    public decimal SetDiscountPrice(decimal basePrice)
    {
        return basePrice - basePrice * Discount;
    }
}