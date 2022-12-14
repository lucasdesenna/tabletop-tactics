using Assets.Core.Entities;
using Assets.Core.Enums;
using Assets.Core.Services;
using Moq;

namespace Tests.Services
{
    public class ShoppingServiceTests
    {
        [Test]
        public void SoldierCostTest()
        {
            Mock<ISoldier> soldierMock = new();
            soldierMock.Setup(m => m.SoldierType).Returns(SoldierType.APOTHECARY);

            Assert.That(ShoppingService.SoldierCost(soldierMock.Object), Is.EqualTo(100));
        }

        [Test]
        public void HireSoldierTest()
        {
            Mock<IWarband> warbandMock = new();
            warbandMock.SetupProperty(m => m.Funds, 100);

            List<ISoldier> soldiers = new();
            warbandMock.Setup(m => m.Soldiers).Returns(soldiers);

            Mock<ISoldier> soldierMock = new();
            soldierMock.Setup(m => m.SoldierType).Returns(SoldierType.APOTHECARY);

            warbandMock.Setup(m => m.AddSoldier(It.IsAny<ISoldier>()))
                .Callback((ISoldier soldier) => soldiers.Add(soldier));

            ShoppingService.HireSoldier(warbandMock.Object, soldierMock.Object);

            Assert.Multiple(() =>
            {
                Assert.That(warbandMock.Object.Funds, Is.EqualTo(0));
                Assert.That(warbandMock.Object.Soldiers, Contains.Item(soldierMock.Object));
                Assert.Throws<Exception>(() => ShoppingService.HireSoldier(warbandMock.Object, soldierMock.Object));
            });
        }

        [Test]
        public void DismissSoldierTest()
        {
            Mock<IWarband> warbandMock = new();

            List<ISoldier> soldiers = new();
            warbandMock.Setup(m => m.Soldiers).Returns(soldiers);

            Mock<ISoldier> soldierMock = new();
            soldiers.Add(soldierMock.Object);

            warbandMock.Setup(m => m.RemoveSoldier(It.IsAny<ISoldier>()))
                .Callback((ISoldier soldier) => soldiers.Remove(soldier));

            ShoppingService.DismissSoldier(warbandMock.Object, soldierMock.Object);

            Assert.That(warbandMock.Object.Soldiers, !Contains.Item(soldierMock.Object));
        }

        [Test]
        public void BuyItemTest()
        {
            Mock<IWarband> warbandMock = new();
            warbandMock.SetupProperty(m => m.Funds, 100);

            List<IItem> items = new();
            warbandMock.Setup(m => m.Items).Returns(items);

            Mock<IItem> itemMock = new();
            itemMock.Setup(m => m.Value).Returns(100);

            warbandMock.Setup(m => m.AddItem(It.IsAny<IItem>()))
                .Callback((IItem item) => items.Add(item));

            ShoppingService.BuyItem(warbandMock.Object, itemMock.Object);

            Assert.Multiple(() =>
            {
                Assert.That(warbandMock.Object.Funds, Is.EqualTo(0));
                Assert.That(warbandMock.Object.Items, Contains.Item(itemMock.Object));
                Assert.Throws<Exception>(() => ShoppingService.BuyItem(warbandMock.Object, itemMock.Object));
            });
        }

        [Test]
        public void SellItemTest()
        {
            Mock<IWarband> warbandMock = new();
            warbandMock.SetupProperty(m => m.Funds, 0);

            List<IItem> items = new();
            warbandMock.Setup(m => m.Items).Returns(items);

            Mock<IItem> itemMock = new();
            itemMock.Setup(m => m.Value).Returns(100);
            items.Add(itemMock.Object);

            warbandMock.Setup(m => m.RemoveItem(It.IsAny<IItem>()))
                .Callback((IItem item) => items.Remove(item));


            ShoppingService.SellItem(warbandMock.Object, itemMock.Object);

            Assert.Multiple(() =>
            {
                Assert.That(warbandMock.Object.Funds, Is.EqualTo(50));
                Assert.That(warbandMock.Object.Items, !Contains.Item(itemMock.Object));
            });
        }

        [Test]
        public void ApprenticeCostTest()
        {

        }
    }
}
