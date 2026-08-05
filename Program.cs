namespace OOP_02___Smart_Delivery_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  // Question 1

            //Part 01 : Theoretical Questions

            //a) What is the difference between a class and a struct? 

            /*
    
            1- Struct:
               - User-defined data type.
               - Value Type.
               - Stores its data directly (usually on the stack for local variables).
               - Does not support inheritance from another class or struct.
               - Best for small, lightweight data.

            2- Class:
               - User-defined data type.
               - Reference Type.
               - The object is stored on the heap, while the reference variable holds its address.
               - Supports all four OOP pillars (Encapsulation, Inheritance, Polymorphism, Abstraction).
               - Best for large and complex applications.
            */


            // b) Why are classes more suitable than structs for large applications?

            /*
            Classes are more suitable for large applications because:
            1- They support all four OOP pillars:
               - Encapsulation
               - Inheritance
               - Polymorphism
               - Abstraction

            2- They allow object sharing through references, which reduces unnecessary copying.

            3- They are better for complex objects that contain a lot of data and behavior.
            */
            #endregion

            #region // Question 2

            //Question 2

            //Consider the following code:

            //a) Which class is the parent class?
            //---> Shipment
            //b) Which class is the child class?
            //---> ExpressShipment 

            //c) What members are inherited by ExpressShipment?
            //---> TrackingCode

            //d) Why is inheritance better than duplicating the same code in multiple classes?
            //---> nheritance is better because it reduces code duplication, improves code reusability,
            //and makes the application easier to maintain.



            #endregion
        }
    }
}
