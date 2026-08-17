using System.Numerics;
using System.Timers;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_oop_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Part 01 — Theoretical Questions

            //Q1  Overloading, Overriding, and Binding
            //            a)  What is the difference between Method Overloading and Method Overriding?

            //            a) Method Overloading vs.Method Overriding

            //Method Overloading:

            //            Same class.

            //Same method name, different parameters(type, number, or order).

            //Resolved at compile-time(Compile-time Polymorphism).

            //Method Overriding:

            //Derived class (Inheritance).

            //Same method name and identical signature(virtual in parent, override in child).

            //Resolved at runtime(Runtime Polymorphism).


            //b)  What is the difference between Static Binding and Dynamic Binding?




//            b) Static Binding vs.Dynamic Binding

//Static Binding(Early Binding):

//Method call is resolved at compile - time.

//Based on the reference type of the object.

//Used with Method Overloading, static methods, and non -virtual methods.

//Offers faster execution performance.

//Dynamic Binding (Late Binding):

//Method call is resolved at runtime.

//Based on the actual object type created in memory.

//Used with Method Overriding and virtual methods.

//Has a slight performance overhead due to runtime lookup.


            #endregion

        }
    }
}
