using Assets.Core.Entities;
using Assets.Core.Interfaces;
using Moq;

namespace Tests.Interfaces
{
    public class IWithInventoryTest
    {
        [TestFixture]
        private class WithInventory : IWithInventory
        {
            private int? _itemCapacity = null;
            public int? ItemCapacity => _itemCapacity;

            private readonly List<IItem> _items = new();
            public List<IItem> Items => _items;

            public WithInventory() { }

            public WithInventory(int? itemCapacity) {
                _itemCapacity = itemCapacity;
            }
        }


        [Test]
        public void DefaultAddItemTest()
        {
            IWithInventory withInvetory = new WithInventory(1);

            Mock<IItem> itemMock = new();

            withInvetory.AddItem(itemMock.Object);

            Assert.Multiple(() =>
            {
                Assert.That(withInvetory.Items, Contains.Item(itemMock.Object));
                Assert.That(withInvetory.Items, Has.Count.EqualTo(1));
                Assert.Throws<InvalidOperationException>(() => withInvetory.AddItem(itemMock.Object));
            });
        }

        [Test]
        public void DefaultAddItemToUnboundInventoryTest()
        {
            IWithInventory withInvetory = new WithInventory();

            Mock<IItem> itemMock = new();

            withInvetory.AddItem(itemMock.Object);

            Assert.Multiple(() =>
            {
                Assert.That(withInvetory.Items, Contains.Item(itemMock.Object));
                Assert.That(withInvetory.Items, Has.Count.EqualTo(1));
            });
        }

        [Test]
        public void DefaultRemoveItemTest()
        {
            IWithInventory withInvetory = new WithInventory(1);

            Mock<IItem> itemMock = new();
            withInvetory.AddItem(itemMock.Object);

            withInvetory.RemoveItem(itemMock.Object);

            Assert.Multiple(() =>
            {
                Assert.That(withInvetory.Items, !Contains.Item(itemMock.Object));
                Assert.That(withInvetory.Items, Is.Empty);
            });
        }
    }
}
