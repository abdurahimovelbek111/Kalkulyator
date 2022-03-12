using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulyator1998
{
    class CLASS
    {
        public double a = 0, a1;
        private void get_n(int _a) { a = _a; }
        public void bosish(double _c)
        {
            a1 = _c;
        }
        public void Hisobla(int amal)
        {

            if (amal == 1) a = a + a1;
            if (amal == 2) a = a - a1;
            if (amal == 3) a = a * a1;
            if (amal == 4) a = a / a1;
            if (amal == 5) a = Math.Pow(a, a1);
            if (amal == 6) a = a1 * a / 100;
            if (amal == 7) a = a % a1;
            if (amal == 8) a = Math.Pow(a, 1 / a1);
            if (a == 0) a = a1;
        }
        public double foiz()
        {
            a1 = (a * a1) / 100;
            a = 0;
            return a1;
        }
        public double natija()
        {
            return a;
        }
        public void uchirish()
        {
            a = 0;
        }
    }
    class Injiner : CLASS
    {
        public int faktaryal(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
                s = s * i;
            return s;
        }
        public double ildiz(double x)
        {
            double k = Math.Sqrt(x);
            return k;
        }
        public double Logarifim(double x)
        {
            double k = Math.Log(x);
            return k;
        }
        public double lnlog(double x)
        {
            double k = Math.Log(x);
            return k;
        }
        public double tangens(double x, bool radian)
        {
            if (radian) a = Math.Tan(x);
            else a1 = Math.Tan((x * Math.PI) / 180);
            return a1;
        }
        public double sinus(double x, bool radian)
        {
            if (radian) a1 = Math.Sin(x);
            else a1 = Math.Sin((x * Math.PI) / 180);
            return a1;
        }
        public double cosinus(double x, bool radian)
        {
            if (radian) a1 = Math.Cos(x);
            else a1 = Math.Cos((x * Math.PI) / 180);
            return a1;
        }
        public double sinush(double x, bool radian)
        {
            if (radian) a1 = Math.Sinh(x);
            else a1 = Math.Sinh((x * Math.PI) / 180);
            return a1;
        }
        public double tangensh(double x, bool radian)
        {
            if (radian) a1 = Math.Tanh(x);
            else a1 = Math.Tanh((x * Math.PI) / 180);
            return a1;
        }
        public double cosh(double x, bool radian)
        {
            if (radian) a1 = Math.Cosh(x);
            else a1 = Math.Cosh((x * Math.PI) / 180);
            return a1;
        }
    }
    class programma : CLASS
    {
        public int nat()
        {
            if (a == 0)
                return (int)a1;
            else return (int)a;
        }
        public void bosishp(int son) { a1 = son; }
    } 
}
