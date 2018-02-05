using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingCode;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DenTest()
        {
            var t = int.MaxValue;

            try
            {
                checked
                {
                    t = t * 2;
                }
            } catch (OverflowException ex)
            {
                Debug.WriteLine(t + "test!");
            }

            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();

            A obj4 = new A();
            obj4.Foo();

            B obj5 = new C();

            obj5.Foo();

            int[] testArray = new int[5] { 3, 2, 3, 4, 1 };

            int[] result = testArray.Reverse().Take<int>(2).Reverse().ToArray<int>();

            Debug.Write(result.Count());

            YieldTestClass testYield = new YieldTestClass();
           
            foreach (int numb in testYield.SquareNumbers)
            {
                Debug.Write(numb);
            }
                     
            return View();
        }

        public ActionResult DenPartialView()
        {
            return PartialView();
        }
    }

    class A
    {
        private int v = 3;

        public int getV {
            get { return v; }
            }

        public virtual void Foo()
        {
            Console.Write("Class A");
        }
    }
    class B : A
    {
        int v = 4;

        public override void Foo()
        {
            Console.Write("Class B " + getV);
        }
    }

    class C : B
    {
        int v = 4;
            
        public override void Foo()
        {
            Console.Write("Class C " + getV);

            int[] array = new int[] { 3, 2, 5};

            Array.Sort(array);                    
        }
    }
}