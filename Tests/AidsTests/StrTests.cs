﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order.Aids;

namespace Tests.Aids
{
    [TestClass]
    public class StrTest
    {
        [TestMethod]
        public void EmptyIfNullTest()
        {
            Assert.AreEqual(string.Empty, Str.EmptyIfNull(null));
            Assert.AreEqual(" ", Str.EmptyIfNull(" "));
        }
    }
}