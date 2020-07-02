using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine_Amar;
using PromotionEngine_Amar.Entities;
using System.Collections.Generic;

namespace PromotionEngineUnitTest
{
    [TestClass]
    public class PromotionTest
    {
        [TestMethod]
        public void Process_ScenarioA()
        {
            var carts = new Cart
            {
                Cartitems = new List<Cartitem> {new Cartitem{Skuname = "A",Quantity=1,Price=50},
                    new Cartitem{Skuname = "B",Quantity=1 ,Price=30},
                    new Cartitem{Skuname = "C",Quantity=1,Price=20 } }
            };
            Promotion promotion = new Promotion();
            var value = promotion.Process(carts);
            Assert.AreEqual(100, value);
        }

        [TestMethod]
        public void Process_ScenarioB()
        {
            var carts = new Cart
            {
                Cartitems = new List<Cartitem> {new Cartitem{Skuname = "A",Quantity=5 },
                    new Cartitem{Skuname = "B",Quantity=5 ,Price=250},
                    new Cartitem{Skuname = "C",Quantity=1,Price=150 } }
            };
            Promotion promotion = new Promotion();
            var value = promotion.Process(carts);
            Assert.AreEqual(370, value);
        }

        [TestMethod]
        public void Process_ScenarioC()
        {
            var carts = new Cart
            {
                Cartitems = new List<Cartitem> {new Cartitem{Skuname = "A",Quantity=3},
                    new Cartitem{Skuname = "B",Quantity=5 },
                    new Cartitem{Skuname = "C",Quantity=1},
                    new Cartitem{Skuname = "D",Quantity=1 } }
            };
            Promotion promotion = new Promotion();
            var value = promotion.Process(carts);
            Assert.AreEqual(280, value);
        }

        [TestMethod]
        public void Process_CartitemOnlyhaveSkuA()
        {
            var carts = new Cart
            {
                Cartitems = new List<Cartitem> { new Cartitem { Skuname = "A", Quantity = 5 } }
            };
            Promotion promotion = new Promotion();
            var value = promotion.Process(carts);
            Assert.AreEqual(230, value);
        }
    }
}
