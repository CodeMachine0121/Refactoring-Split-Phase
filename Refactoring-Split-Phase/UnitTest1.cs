using Refactoring_Split_Phase.Enums;
using Refactoring_Split_Phase.Models;
using Refactoring_Split_Phase.Services;

namespace Refactoring_Split_Phase;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void should_get_right_price()
    {
        var priceOrder = new PriceOrder();
        var price = priceOrder.GetPrice(Weapon.Sword, 0.05m, new Materials()
        {
            Material = "Wood",
            Quality = Quality.Good
        });

        Assert.That(price, Is.EqualTo(  156.75m));
    }
}