using Refactoring_Split_Phase.Enums;
using Refactoring_Split_Phase.Models;

namespace Refactoring_Split_Phase.Services;

public class PriceOrder
{
    public decimal GetPrice(Weapon weapon, decimal discount, Materials materials)
    {
        var commodityDto = new CommodityDto
        {
            Weapon = weapon,
            Materials = materials,
            Discount = discount
        };
        var basePrice = commodityDto.SetPriceByCommodity(100m);

        basePrice = commodityDto.SetDiscountPrice(basePrice);
        return basePrice;
    }
}

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