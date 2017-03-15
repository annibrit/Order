using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order.Aids;

namespace Tests
{
    public class CommonTests

    {

        protected double MinDouble = double.MinValue;
        protected double MaxDouble = double.MaxValue;

        protected void ObjectPropertyTest<T>(Func<T> get, Action<T> set)
            where T : new()
        {
            Assert.IsNotNull(get());
            set(default(T));
            Assert.IsNotNull(get());
            var s = new T();
            set(s);
            Assert.AreEqual(s, get());
        }

        protected void StringPropertyTest(Func<string> get, Action<string> set)
        {
            Assert.AreEqual(string.Empty, get());
            set(null);
            Assert.AreEqual(string.Empty, get());
            var s = Rnd.String();
            set(s);
            Assert.AreEqual(s, get());
        }

        protected void IntPropertyTest(Func<int> get, Action<int> set)
        {
            Assert.AreEqual(0, get());
            var d = Rnd.Integer();
            set(d);
            Assert.AreEqual(d, get());
        }
    }
}
