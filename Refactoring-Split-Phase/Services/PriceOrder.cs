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
        return commodityDto.SetDiscountPrice(basePrice);
    }
}