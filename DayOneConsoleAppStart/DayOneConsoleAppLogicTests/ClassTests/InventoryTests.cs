using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOneConsoleAppLogic;

namespace DayOneConsoleAppLogicTests
{
    [TestClass]
    public class InventoryTests
    {
        private Inventory items;
        private int heightDimension = 5;
        private int widthDimension = 6;
        bool addItem;
        Item item1 = new Item("GoosePoop", 1, 1);
        Item item2 = new Item("DogPoop", 1, 1);
        Item item3 = new Item("CatShit", 1, 1);
        Item item4 = new Item("FishPoo", 1, 1);

        [TestInitialize]
        public void Initialize()
        {
            //items = new Item[heightDimension, widthDimension];
            items = new Inventory(heightDimension, widthDimension);
            addItem = true;
            //items.AcceptItem(item1);
            //items.AcceptItem(item2);
            //items.AcceptItem(item3);
            //items.AcceptItem(item4);
            items.ChangeItem(item1,addItem);
            items.ChangeItem(item2, addItem);
            items.ChangeItem(item3, addItem);
            items.ChangeItem(item4,addItem);
        }

        [TestMethod]
        public void VerifyItemsWereAddedCorrectly()
        {
            Assert.IsNotNull(items);
            Assert.IsTrue(items.Items[0, 0] == item1);
            Assert.IsTrue(items.Items[0, 1] == item2);
            Assert.IsTrue(items.Items[0, 2] == item3);
            Assert.IsTrue(items.Items[0, 3] == item4);
            Assert.IsNull(items.Items[0, 4]);
        }

        [TestMethod]
        public void VerifyItemsWereRemovedCorrectly()
        {
            addItem = false;
            items.ChangeItem(item1,addItem);
            items.ChangeItem(item3,addItem);
            Assert.IsTrue(items.Items[0, 0] == null);
            Assert.IsTrue(items.Items[0, 1] == item2);
            Assert.IsTrue(items.Items[0, 2] == null);
            Assert.IsTrue(items.Items[0, 3] == item4);
            Assert.IsNull(items.Items[0, 4]);
        }

        [TestMethod]
        public void VerifyItemsCanBeRemovedOutOfOrder()
        {
            addItem = false;
            items.ChangeItem(item3,addItem);
            items.ChangeItem(item1,addItem);
            Assert.IsTrue(items.Items[0, 0] == null);
            Assert.IsTrue(items.Items[0, 1] == item2);
            Assert.IsTrue(items.Items[0, 2] == null);
            Assert.IsTrue(items.Items[0, 3] == item4);
            Assert.IsNull(items.Items[0, 4]);
        }
    }
}
