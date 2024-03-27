using Refactoring_Split_Phase.Enums;
using Refactoring_Split_Phase.Models;

namespace Refactoring_Split_Phase.Services;

public class PriceOrder
{
    public decimal GetPrice(Weapon weapon, double discount, Materials materials)
    {
        var commodityDto = new CommodityDto
        {
            Weapon = weapon,
            Materials = materials,
        };
        var basePrice = commodityDto.SetPriceByCommodity(100m);

        basePrice -= basePrice * (decimal)discount;
        return basePrice;
    }
}

public class CommodityDto
{
    public Weapon Weapon { get; set; }
    public Materials Materials { get; set; }

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
}