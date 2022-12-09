namespace Tests.Entities
{
    public class InventoryTests
    {
        [Test]
        public void CanBeConstructed()
        {
            Assert.DoesNotThrow(() => new Inventory());
        }

        [Test]
        public void CanBeConstructedWithMaximumCapacity()
        {
            Inventory inventory = new(1);
            Assert.Multiple(() =>
            {
                Assert.That(inventory.Capacity, Is.EqualTo(1));
            });
        }

        [Test]
        public void KnowsWhenItIsFull()
        {
            Inventory inventory = new();

            Assert.That(inventory.IsFull, Is.EqualTo(false));

            Inventory inventoryWithLimitedCapacity = new(1);

            Assert.That(inventoryWithLimitedCapacity.IsFull, Is.EqualTo(false));

            inventoryWithLimitedCapacity.AddItem(new Item());

            Assert.That(inventoryWithLimitedCapacity.IsFull, Is.EqualTo(true));
        }

        [Test]
        public void CanAddItem()
        {
            Inventory inventory = new();

            Assert.That(inventory.Items, Has.Count.EqualTo(0));

            inventory.AddItem(new Item());

            Assert.That(inventory.Items, Has.Count.EqualTo(1));
        }

        [Test]
        public void CanNotAddItemWhenFull()
        {
            Inventory inventory = new(0);

            Assert.That(inventory.IsFull, Is.EqualTo(true));

            Assert.Throws<InvalidOperationException>(() => inventory.AddItem(new Item()));
        }
    }
}
