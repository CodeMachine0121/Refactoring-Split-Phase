using Refactoring_Split_Phase.Enums;
using Refactoring_Split_Phase.Models;

namespace Refactoring_Split_Phase.Services;

public class PriceOrder
{
    public decimal GetPrice(Weapon weapon, double discount, Materials materials)
    {
        var basePrice = 100m;
        basePrice = SetPriceByCommodity(weapon, materials, basePrice);

        basePrice -= basePrice * (decimal)discount;
        return basePrice;
    }

    private static decimal SetPriceByCommodity(Weapon weapon, Materials materials, decimal totalPrice)
    {
        if (weapon == Weapon.Sword)
        {
            totalPrice += 30;
        }

        if (materials.Material == "Wood")
        {
            totalPrice += 20;
            if (materials.Quality == Quality.Good)
            {
                totalPrice += totalPrice * 0.1m;
            }
        }

        return totalPrice;
    }
}