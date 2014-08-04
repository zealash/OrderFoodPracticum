using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderAgent;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
namespace OrderAgent.Tests
{
    [TestClass()]
    public class OrderExpeditorTests
    {

        [TestInitialize]
        public void IntitializeTestObject()
        {

        }

        [TestMethod()]
        public void GetOrder_Morning_OneOfEach_EntreeSideDrink_Test()
        {
            string[] inputOrder = new string[]{"morning","2","1","3"};

            OrderExpeditor agent = new OrderExpeditor();

            string result = agent.GetOrder(inputOrder);

            Assert.AreEqual("output: eggs,toast,coffee", result);
        }

        [TestMethod()]
        public void GetOrder_Morning_MultpleOrdersOfEntree_Test()
        {
            string[] inputOrder = new string[] { "morning", "1", "1", "3" };

            OrderExpeditor agent = new OrderExpeditor();

            string result = agent.GetOrder(inputOrder);

            Assert.AreEqual("output: eggs,error", result);
        }

        [TestMethod()]
        public void GetOrder_Morning_GetErrorForDessertOrder_Test()
        {
            string[] inputOrder = new string[] { "morning", "1", "2", "3","4" };

            OrderExpeditor agent = new OrderExpeditor();

            string result = agent.GetOrder(inputOrder);

            Assert.AreEqual("output: eggs,toast,coffee,error", result);
        }

        [TestMethod()]
        public void GetOrder_Morning_MultipleOrderOfDrink_Test()
        {
            string[] inputOrder = new string[] { "morning", "1", "2", "3", "3", "3" };

            OrderExpeditor agent = new OrderExpeditor();

            string result = agent.GetOrder(inputOrder);

            Assert.AreEqual("output: eggs,toast,coffee(x3)", result);
        }

        [TestMethod()]
        public void GetOrder_Night_OneOfEach_EntreeSideDrinkDessert_Test()
        {
            string[] inputOrder = new string[] { "night", "1", "2", "3", "4" };

            OrderExpeditor agent = new OrderExpeditor();

            string result = agent.GetOrder(inputOrder);

            Assert.AreEqual("output: steak,potato,wine,cake", result);
        }

        [TestMethod()]
        public void GetOrder_Night_MultipleOrdersOfPotato_Test()
        {
            string[] inputOrder = new string[] { "night", "1", "2", "2", "4" };

            OrderExpeditor agent = new OrderExpeditor();

            string result = agent.GetOrder(inputOrder);

            Assert.AreEqual("output: steak,potato(x2),cake", result);
        }

        [TestMethod()]
        public void GetOrder_Night_InvalidOrder_Test()
        {
            string[] inputOrder = new string[] { "night", "1", "2", "3", "5" };

            OrderExpeditor agent = new OrderExpeditor();

            string result = agent.GetOrder(inputOrder);

            Assert.AreEqual("output: steak,potato,wine,error", result);
        }

        [TestMethod()]
        public void GetOrder_Night_ErrorForMultipleOrdersOfEntree_Test()
        {
            string[] inputOrder = new string[] { "night", "1", "1","2", "3", "5" };

            OrderExpeditor agent = new OrderExpeditor();

            string result = agent.GetOrder(inputOrder);

            Assert.AreEqual("output: steak,error", result);
        }
    }
}
