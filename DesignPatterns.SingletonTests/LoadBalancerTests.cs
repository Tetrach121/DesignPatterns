using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Singleton;
using DesignPatterns.FactoryMethod_Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.Tests
{
    [TestClass()]
    public class LoadBalancerTests
    {
        [TestMethod()]
        public void GetLoadBalancerTest()
        {
            //arrange
            LoadBalancer l1, l2;
            //act
            l1 = LoadBalancer.GetLoadBalancer();
            l2 = LoadBalancer.GetLoadBalancer();
            //assert
            Assert.AreSame(l1, l2);
        }

        [TestMethod()]
        public void ServerListTest()
        {
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            string server = balancer.Server;
            switch (server)
            {
                case "Server I":
                case "Server II":
                case "Server III":
                case "Server IV":
                case "Server V":
                    Assert.IsTrue(true);
                    break;
                default:
                    Assert.Fail();
                    break;
            }
        }

        [TestMethod()]
        public void LoadBalancerNullTest()
        {
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            Assert.IsNotNull(balancer);
        }

        [TestMethod()]
        public void LoadBalancerInstanceTest()
        {
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            Assert.IsInstanceOfType(balancer, typeof(LoadBalancer));
        }

        [TestMethod()]
        public void FactryMethodSameTest()
        {
            Assert.IsFalse(typeof(Resume) == typeof(Report));
        }

        [TestMethod()]
        public void FactoryMethodTest2()
        {
            Document d = new Resume();
            Assert.IsNotInstanceOfType(d, typeof(Report));
        }
    }
}