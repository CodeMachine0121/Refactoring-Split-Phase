using Refactoring_Split_Phase.Enums;
using Refactoring_Split_Phase.Models;

namespace Refactoring_Split_Phase.Services;

public class PriceOrder
{
    public decimal GetPrice(Weapon weapon, double discount, Materials materials)
    {
        var basePrice = 100m;
        basePrice = SetPriceByCommodity(new CommodityDto
        {
            Weapon = weapon,
            Materials = materials,
        }, basePrice);

        basePrice -= basePrice * (decimal)discount;
        return basePrice;
    }

    private static decimal SetPriceByCommodity(CommodityDto dto,
        decimal totalPrice)
    {
        if (dto.Weapon == Weapon.Sword)
        {
            totalPrice += 30;
        }

        if (dto.Materials.Material == "Wood")
        {
            totalPrice += 20;
            if (dto.Materials.Quality == Quality.Good)
            {
                totalPrice += totalPrice * 0.1m;
            }
        }

        return totalPrice;
    }
}

public class CommodityDto
{
    public Weapon Weapon { get; set; }
    public Materials Materials { get; set; }
}