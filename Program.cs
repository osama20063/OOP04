using System.Collections;
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






            #region Part 01 2


            //            (Q2: Sealed Classes and Methods):

            //a) Purpose of the sealed keyword when applied to a class:
            //The sealed keyword prevents other classes from inheriting from it.It is used to restrict inheritance, protect the class design, and improve security and compiler optimizations.

            //b) Difference between a sealed class and a sealed method:

            //Sealed Class: Prevents any class from inheriting/deriving from it(it cannot be a base/parent class).

            //Sealed Method: Prevents a derived class from further overriding that specific method.It can only be applied to a method that is already overriding a virtual method from a base class (using sealed override).

            //c) Can a sealed method be overridden? Why?
            //No, a sealed method cannot be overridden.
            //Why: The explicit purpose of applying the sealed modifier to an overridden method is to break the virtual chain and guarantee that no further derived classes can alter its implementation.

            #endregion







            #region Part 02 — Practical
            //1  Update the Shipment Class

        //    public class Shipment
        //{
        //    public double Weight { get; set; }

        //    public virtual decimal EstimatedCost { get; set; }

        //    public virtual void PrintShipment()
        //    {
        //        Console.WriteLine($"Shipment Cost: {EstimatedCost}");
        //    }

        //    public void UpdateWeight(double weight)
        //    {
        //        Weight = weight;
        //    }

        //    public void UpdateWeight(double weight, double extraPackingWeight)
        //    {
        //        Weight = weight + extraPackingWeight;
        //    }
        


            #endregion

    }
    }
}
