using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{

    /// <summary>
    /// test class for Order class
    /// </summary>
    public class OrderTest
    {

        /// <summary>
        /// creates temp order for testing purposes
        /// </summary>
        public class MockOrderItem: IOrderItem
        {
            public double Price { get; set; }

            public List<string> SpecialInstructions { get; set; }
        }


        /// <summary>
        /// tests functionality of adding items
        /// </summary>
        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }
        
        /// <summary>
        /// tests functionality of removing items
        /// </summary>
        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }


        /// <summary>
        /// tests functionality of retrieving a enumeration of the list of items
        /// </summary>
        [Fact]
        public void ShouldBeAbleToGetTheEnumerationOfTheListOfItems()
        {
            var order = new Order();
            var item0 = new MockOrderItem();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();
            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            Assert.Collection(order.Items,
                item => Assert.Equal(item0, item),
                item => Assert.Equal(item1, item),
                item => Assert.Equal(item2, item));
        }


        /// <summary>
        /// tests cases of subtotal 
        /// </summary>
        /// <param name="Prices"></param>
        [Theory]
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 0,0,0,})]
        [InlineData(new double[] { 199.33, 799 })]
        [InlineData(new double[] { 798})]
        [InlineData(new double[] { })]
        [InlineData(new double[] { -5 })]
        [InlineData(new double[] { -4, 10, 8 })]
        [InlineData(new double[] { 3.145234262})]
        [InlineData(new double[] { double.NaN })]
        public void SubtotoalShouldBeSumOfTheItemPrices(double[] Prices)
        {
            var order = new Order();
            double total = 0;
            foreach(var price in Prices)
            {
                total += price;
                order.Add(new MockOrderItem()
                {
                    Price = price
                });
            }
            Assert.Equal(total, order.Subtotal);
        }

        /// <summary>
        /// trests cases of the price or Items property changing on adding items
        /// </summary>
        /// <param name="propertyName"></param>
        [Theory]
        [InlineData("Prices")]
        [InlineData("Items")]
        public void AddingAnItemShouldTriggerPropertyChangedForPrice(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () => {
                order.Add(item);
            });
        }

        /// <summary>
        /// tests cases of the price and items proprty changing on removing items
        /// </summary>
        /// <param name="propertyName"></param>
        [Theory]
        [InlineData("Prices")]
        [InlineData("Items")]
        public void RemovingAnItemShouldTriggerPropertyChangedForItems(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () => {
                order.Remove(item);
            });
        }
    }
}
