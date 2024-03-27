using Refactoring_Split_Phase.Enums;
using Refactoring_Split_Phase.Models;

namespace Refactoring_Split_Phase.Services;

public class PriceOrder
{
    public decimal GetPrice(Weapon weapon, double discount, Materials materials)
    {
        var totalPrice = 0m;
        var basePrice = 100m;
        if (weapon == Weapon.Sword)
        {
            totalPrice += 30;
        }
        if (materials.Material == "Wood")
        {
            totalPrice += 20;
            if (materials.Quality == Quality.Good)
            {
                totalPrice += totalPrice* 0.1m;
            }
        }
        
        totalPrice -= totalPrice * (decimal) discount;
        return totalPrice;
    }
}