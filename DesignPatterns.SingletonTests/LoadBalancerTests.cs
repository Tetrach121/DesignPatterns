using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Singleton;
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
            Assert.AreEqual(l1, l2);
        }
    }
}