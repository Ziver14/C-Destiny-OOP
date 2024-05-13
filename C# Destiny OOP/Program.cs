using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zoo;

namespace C__Destiny_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alligator Al = new Alligator("Jonh");
            Al.Info();

            Cangol Ca = new Cangol("Mat");
            Ca.Info();
        }

    }
    //public abstract class CDA
    //{
    //    public abstract void B(int x);
    //}
    //public class ABC    // если добавить слово scaled то это запретит наследование от этого класса
    //{
    //    public ABC() { }
    //    public static void A () { }


    //}

    //public class BCA : ABC 
    //{
    //    public BCA():base() { } //конструктор наследуется от базового класса
    //}

    //public abstract class Geometric
    //{
    //    public abstract double S();
    //    public abstract double P();
    //}

    //public class Triangle : Geometric
    //{
    //    public int A {  get; set; }
    //    public int B { get; set; }
    //    public int C { get; set; }
    //    public Triangle ( int A,int B,int C)
    //    {
    //        this.A = A;
    //        this.B = B;
    //        this.C = C;
    //    }
    //    public override double S()
    //    {
    //        return A * B * C;
    //    }
    //    public override double P()
    //    {
    //        return A + B + C;
    //    }
    //}

    //public class Quadrat : Geometric
    //{
    //    public int A { get; set; }
    //    public int B { get; set; }
    //    public int C { get; set; }
    //    public int D { get; set; }

    //    public Quadrat(int a, int b, int c, int d)
    //    {
    //        A = a;
    //        B = b;
    //        C = c;
    //        D = d;
    //    }

    //    public override double S()
    //    {
    //        return A * B;
    //    }

    //    public override double P()
    //    {
    //        return 4*A;
    //    }
    //}

    //public class Rectangle : Geometric
    //{
    //    public int A { get; set; }
    //    public int B { get; set; }

    //    public Rectangle(int a, int b)
    //    {
    //        A = a;
    //        B = b;
    //    }

    //    public override double S()
    //    {
    //        return A * B;
    //    }
    //    public override double P()
    //    {
    //        return (A + B) * 2;
    //    }

    //}

    //public class Rhomb : Geometric
    //{
    //    public int A { get; set; }
    //    public int B { get; set; }
    //    public int D1 { get; set; }
    //    public int D2 { get; set; }
    //    public Rhomb(int a, int b, int d1, int d2)
    //    {
    //        A = a;
    //        B = b;
    //        D1 = d1;
    //        D2 = d2;
    //    }
    //    public override double S()
    //    {
    //        return A * D1;
    //    }

    //    public override double P()
    //    {
    //        return 2 * (Math.Sqrt(D1 * D1 + D2 * D2));
    //    }

    //}

    //class Parallelogramm : Geometric
    //{
    //    public int A { get; set; }
    //    public int B { get; set; }
    //    public int H { get; set; }


    //    public Parallelogramm(int a,int b, int h)
    //    {
    //        A = a; B = b;
    //        H = h;
    //    }

    //    public override double S() 
    //    {
    //        return A * H;        
    //    }
    //    public override double P()
    //    {
    //        return (A + B) * 2;
    //    }
    //}

    

   }
