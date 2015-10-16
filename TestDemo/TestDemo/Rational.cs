using System;
using NUnit.Framework;
using System.Diagnostics;

namespace TestDemo
{
    public class Rational
    {
        private int num, denom;

        public Rational(int n, int d)
        {
            num = n;
            denom = d;

            Simplify();
        }

        private void Simplify()
        {
            int gcd, least;

            if (denom == 0 || num == 0) return;

            // make sure denominator is positive
            if (denom < 0)
            {
                denom = -denom;
                num = -num;
            }

            // find smallest absolute value
            if (Math.Abs(num) < denom)
                least = Math.Abs(num);
            else
                least = denom;

            // find greatest common denominator of num and denom
            for (gcd = least; gcd > 1; gcd--)
            {
                if (denom % gcd == 0 && num % gcd == 0) break;
            }

            // reduce rational to smallest values
            num /= gcd;
            denom /= gcd;

            // test class is ok
            TestClass();
        }

        public void TestClass()
        {
            Debug.Assert(denom > 0, "Assertion : denom < 0", "Rational data : " + ToString());
            //Debug.Assert(1 < 0, "Assertion : 1 < 0", "Rational data : " + ToString());
        }

        public int Denominator
        {
            get { return denom; }
        }

        public int Numerator
        {
            get { return num; }
        }

        public override string ToString()
        {
            if (num == 0)
                return "0";
            else if (num % denom == 0)
                return ("" + num / denom);
            else
                return num + "/" + denom;
        }

        public static Rational operator + (Rational a, Rational b)
        {
            // add a and b
            int n = a.num * b.denom + b.num * a.denom;
            int d = a.denom * b.denom;
            return new Rational(n, d);
        }

        public static Rational operator - (Rational a, Rational b)
        {
            // subtract b from a
            int n = a.num * b.denom - b.num * a.denom;
            int d = a.denom * b.denom;
            return new Rational(n, d);
        }

        public static Rational operator * (Rational a, Rational b)
        {
            // multiply a and b
            int n = a.num * b.num;
            int d = a.denom * b.denom;
            return new Rational(n, d);
        }

        public static Rational operator / (Rational a, Rational b)
        {
            // divide a by b
            int n = a.num * b.denom;
            int d = a.denom * b.num;
            return new Rational(n, d);
        }
    }

    [TestFixture] // telling NUnit that this class contains test methods
    public class RationalTest
    {
        [Test] // telling NUnit that this method should be run during tests
        public void Test1()
        {
            Rational r = new Rational(-2, -4);

            Assert.NotNull(r);
            Assert.IsTrue(r.Denominator > 0);
        }

        [Test]
        public void Test2()
        {
            Rational r = new Rational(0, 0);

            Assert.NotNull(r);
            Assert.IsTrue(r.Denominator > 0);
        }
    }
}
