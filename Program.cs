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





            #region PART 2 : 2

            //2  Constructor Chaining



            //مش فاهمه 

            #endregion





            #region PART 2 : 3


            //    public class StandardShipment : Shipment
            //{
            //    public StandardShipment(double weight) : base(weight)
            //    {
            //    }
            //}

            //public class ExpressShipment : Shipment
            //{
            //    public decimal DeliveryFee { get; set; }
            //    public decimal ExtraFee { get; set; }

            //    public ExpressShipment(double weight, decimal deliveryFee, decimal extraFee) : base(weight)
            //    {
            //        DeliveryFee = deliveryFee;
            //        ExtraFee = extraFee;
            //    }

            //    public override decimal EstimatedCost
            //    {
            //        get
            //        {
            //            return DeliveryFee + ((decimal)Weight * 5m) + ExtraFee;
            //        }
            //    }
            //}

            //public class InternationalShipment : Shipment
            //{
            //    public decimal DeliveryFee { get; set; }
            //    public decimal CustomsFee { get; set; }

            //    public InternationalShipment(double weight, decimal deliveryFee, decimal customsFee) : base(weight)
            //    {
            //        DeliveryFee = deliveryFee;
            //        CustomsFee = customsFee;
            //    }

            //    public override decimal EstimatedCost
            //    {
            //        get
            //        {
            //            return DeliveryFee + ((decimal)Weight * 5m) + CustomsFee;
            //        }
            //    }

            #endregion











            #region PART 2 : 4
            //4  Override PrintShipment()

            //    public class StandardShipment : Shipment
            //{
            //    public string TrackingNumber { get; set; }
            //    public string Description { get; set; }
            //    public decimal DeliveryFee { get; set; }

            //    public StandardShipment(double weight, string trackingNumber, string description, decimal deliveryFee) : base(weight)
            //    {
            //        TrackingNumber = trackingNumber;
            //        Description = description;
            //        DeliveryFee = deliveryFee;
            //    }

            //    public override void PrintShipment()
            //    {
            //        Console.WriteLine($"Tracking: {TrackingNumber}, Description: {Description}, Weight: {Weight}, Delivery Fee: {DeliveryFee}, Estimated Cost: {EstimatedCost}");
            //    }
            //}

            //public class ExpressShipment : Shipment
            //{
            //    public string TrackingNumber { get; set; }
            //    public string Description { get; set; }
            //    public decimal DeliveryFee { get; set; }
            //    public decimal ExtraFee { get; set; }

            //    public ExpressShipment(double weight, string trackingNumber, string description, decimal deliveryFee, decimal extraFee) : base(weight)
            //    {
            //        TrackingNumber = trackingNumber;
            //        Description = description;
            //        DeliveryFee = deliveryFee;
            //        ExtraFee = extraFee;
            //    }

            //    public override decimal EstimatedCost => DeliveryFee + ((decimal)Weight * 5m) + ExtraFee;

            //    public override void PrintShipment()
            //    {
            //        Console.WriteLine($"Tracking: {TrackingNumber}, Description: {Description}, Weight: {Weight}, Delivery Fee: {DeliveryFee}, Estimated Cost: {EstimatedCost}, Extra Fee: {ExtraFee}");
            //    }
            //}

            //public class InternationalShipment : Shipment
            //{
            //    public string TrackingNumber { get; set; }
            //    public string Description { get; set; }
            //    public decimal DeliveryFee { get; set; }
            //    public string DestinationCountry { get; set; }
            //    public decimal CustomsFee { get; set; }

            //    public InternationalShipment(double weight, string trackingNumber, string description, decimal deliveryFee, string destinationCountry, decimal customsFee) : base(weight)
            //    {
            //        TrackingNumber = trackingNumber;
            //        Description = description;
            //        DeliveryFee = deliveryFee;
            //        DestinationCountry = destinationCountry;
            //        CustomsFee = customsFee;
            //    }

            //    public override decimal EstimatedCost => DeliveryFee + ((decimal)Weight * 5m) + CustomsFee;

            //    public override void PrintShipment()
            //    {
            //        Console.WriteLine($"Tracking: {TrackingNumber}, Description: {Description}, Weight: {Weight}, Delivery Fee: {DeliveryFee}, Estimated Cost: {EstimatedCost}, Destination Country: {DestinationCountry}, Customs Fee: {CustomsFee}");
            //    }
            //}



            #endregion




            #region PART 2 : 5




            //    public class Driver
            //{
            //    public int DriverId { get; set; }
            //    public string FullName { get; set; }
            //    public string PhoneNumber { get; set; }

            //    public Driver(int driverId, string fullName, string phoneNumber)
            //    {
            //        DriverId = driverId;
            //        FullName = fullName;
            //        PhoneNumber = phoneNumber;
            //    }
            //}

            //public class DeliveryCenter
            //{
            //    public Driver Driver { get; set; }

            //    public DeliveryCenter(Driver driver)
            //    {
            //        Driver = driver;
            //    }
            //}

            //public class DeliveryAddress
            //{
            //    public string Street { get; set; }
            //    public string City { get; set; }
            //    public string Country { get; set; }

            //    public DeliveryAddress(string street, string city, string country)
            //    {
            //        Street = street;
            //        City = city;
            //        Country = country;
            //    }
            //}

            //public class Shipment
            //{
            //    public double Weight { get; set; }
            //    public DeliveryAddress Address { get; private set; }

            //    public Shipment(double weight, string street, string city, string country)
            //    {
            //        Weight = weight;
            //        Address = new DeliveryAddress(street, city, country);
            //    }

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
            //}






            #endregion











            #region PART 2 : 6





        //    public class DeliveryCenter
        //{
        //    private Shipment[] shipments = new Shipment[100];
        //    private int count = 0;

        //    public Driver Driver { get; set; }

        //    public DeliveryCenter(Driver driver)
        //    {
        //        Driver = driver;
        //    }

        //    public void AddShipment(Shipment shipment)
        //    {
        //        if (count < shipments.Length)
        //        {
        //            shipments[count++] = shipment;
        //        }
        //    }

        //    public void RemoveShipment(int index)
        //    {
        //        if (index >= 0 && index < count)
        //        {
        //            for (int i = index; i < count - 1; i++)
        //            {
        //                shipments[i] = shipments[i + 1];
        //            }
        //            shipments[--count] = null;
        //        }
        //    }

        //    public Shipment this[int index]
        //    {
        //        get
        //        {
        //            if (index >= 0 && index < count)
        //                return shipments[index];
        //            return null;
        //        }
        //        set
        //        {
        //            if (index >= 0 && index < count)
        //                shipments[index] = value;
        //        }
        //    }

        //    public Shipment this[string trackingNumber]
        //    {
        //        get
        //        {
        //            for (int i = 0; i < count; i++)
        //            {
        //                if (shipments[i] is StandardShipment s && s.TrackingNumber == trackingNumber)
        //                    return s;
        //                if (shipments[i] is ExpressShipment e && e.TrackingNumber == trackingNumber)
        //                    return e;
        //                if (shipments[i] is InternationalShipment intl && intl.TrackingNumber == trackingNumber)
        //                    return intl;
        //            }
        //            return null;
        //        }
        //    }

        //    public void PrintAllShipments()
        //    {
        //        for (int i = 0; i < count; i++)
        //        {
        //            if (shipments[i] != null)
        //            {
        //                shipments[i].PrintShipment();
        //            }
        //        }
        //    }
        







            #endregion




    }
    }
}
