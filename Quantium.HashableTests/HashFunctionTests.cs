using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Quantium.Hashable.Tests
{
    class TestClass
    {
        [Hashable]
        int b = 9;
        [Hashable]
        double a = Math.PI;
        [Hashable]
        string c = "Howdy, pard'ner";

        public override int GetHashCode()
        {
            return this.Hash();
        }
    }

    class InheritedClass : TestClass
    {
        [Hashable]
        string s1 = "Test";

        public override int GetHashCode()
        {
            return this.Hash();
        }
    }

    class CompositeClass
    {
        [Hashable]
        TestClass t1 = new TestClass();
        [Hashable]
        double d1 = Math.E;

        public override int GetHashCode()
        {
            return this.Hash();
        }
    }


    [TestClass()]
    public class HashFunctionTests
    {
        [TestMethod()]
        public void ClassTest()
        {
            var tester = new TestClass();
            int result = tester.Hash();
            Assert.IsTrue(result == tester.GetHashCode());
        }

        [TestMethod()]
        public void CompositeClassTest()
        {
            var tester = new CompositeClass();
            int result = tester.Hash();
            Assert.IsTrue(result == tester.GetHashCode());
        }

        [TestMethod()]
        public void InheritedClassTest()
        {
            var tester = new InheritedClass();
            int result = tester.Hash();
            Assert.IsTrue(result == tester.GetHashCode());
        }
    }
}