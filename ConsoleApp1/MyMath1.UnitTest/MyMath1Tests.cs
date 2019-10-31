﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyMath1;
using NUnit.Framework;

namespace MyMath1.UnitTest
{
    [TestFixture]
    public class MyMath1Tests
    {
        [Test]
        public void Add_SumWithinByteRange_ReturnCorectSum()
        {
            Assert.AreEqual(200, MyMath.MyMath1.Add(101, 99));

        }
        [Test]
        public void Add_SumOutsideByteRange_ReturnIncorectSum()
        {
            Assert.AreEqual(302, MyMath.MyMath1.Add(101, 201));
        }
        [Test]
        public void Add_SumWithinByteRange_AlternateAssert()
        {
            Assert.That(MyMath.MyMath1.Add(101, 99), Is.EqualTo(200));
        }
        [Test]
        public void Add_SumOutsideByteRange_ThrowsException()
        {
            Assert.That(() => MyMath.MyMath1.Add(101, 201), Throws.Exception);
        }
    }
}
