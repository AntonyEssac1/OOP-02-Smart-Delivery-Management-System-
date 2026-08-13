
namespace OOP_02___Smart_Delivery_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a DeliveryCenter
            Console.Write("Enter Center Name: ");
            string centerName = Console.ReadLine();

            DeliveryCenter Delivery = new DeliveryCenter(centerName);

            Console.WriteLine($"Center Name: {Delivery.CenterName}");
            Console.WriteLine("==================================");


            // Delivery Address
            DeliveryAddress address =
                new DeliveryAddress("Minya", "TahaHessen", 24);


            // 2. Create StandardShipment
            Console.WriteLine("\n=== Standard Shipment ===");

            Console.Write("Enter Tracking Code: ");
            string StandardTrackingCode = Console.ReadLine();

            Console.Write("Enter Description: ");
            string StandardDescription = Console.ReadLine();

            Console.Write("Enter Weight: ");
            decimal StandardWeight = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Delivery Fee: ");
            decimal StandardDeliveryFee = decimal.Parse(Console.ReadLine());

            StandardShipment StandardShipment =
                new StandardShipment(
                    StandardTrackingCode,
                    StandardDescription,
                    StandardWeight,
                    StandardDeliveryFee,
                    address);

            Delivery.AddShipment(StandardShipment);


            // 3. Create ExpressShipment
            Console.WriteLine("\n=== Express Shipment ===");

            Console.Write("Enter Tracking Code: ");
            string ExpressTrackingCode = Console.ReadLine();

            Console.Write("Enter Description: ");
            string ExpressDescription = Console.ReadLine();

            Console.Write("Enter Weight: ");
            decimal ExpressWeight = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Delivery Fee: ");
            decimal ExpressDeliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            ExpressShipment ExpressShipment =
                new ExpressShipment(
                    ExpressTrackingCode,
                    ExpressDescription,
                    ExpressWeight,
                    ExpressDeliveryFee,
                    address,
                    extraFee);

            Delivery.AddShipment(ExpressShipment);


            // 4. Create InternationalShipment
            Console.WriteLine("\n=== International Shipment ===");

            Console.Write("Enter Tracking Code: ");
            string InternationalTrackingCode = Console.ReadLine();

            Console.Write("Enter Description: ");
            string InternationalDescription = Console.ReadLine();

            Console.Write("Enter Weight: ");
            decimal InternationalWeight = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Delivery Fee: ");
            decimal InternationalDeliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Destination Country: ");
            string destinationCountry = Console.ReadLine();

            Console.Write("Enter Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            InternationalShipment InternationalShipment =
                new InternationalShipment(
                    InternationalTrackingCode,
                    InternationalDescription,
                    InternationalWeight,
                    InternationalDeliveryFee,
                    address,
                    destinationCountry,
                    customsFee);

            Delivery.AddShipment(InternationalShipment);


            // 5. Print all shipments
            Console.WriteLine("\n=== All Shipments ===");
            Delivery.PrintAllShipments();


            // 6. Search for a shipment
            Console.Write("\nEnter the tracking code to search for: ");
            string code = Console.ReadLine();

            Shipment shipment1 = Delivery[code];

            if (shipment1 != null)
            {
                Console.WriteLine("\nShipment Found:");
                shipment1.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }


            // 7. Remove a shipment
            Console.Write("\nEnter the tracking code to remove: ");
            string removeCode = Console.ReadLine();

            bool removed = Delivery.RemoveShipment(removeCode);

            if (removed)
            {
                Console.WriteLine("Shipment removed successfully.");
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }


            // 8. Print remaining shipments
            Console.WriteLine("\n=== Remaining Shipments ===");
            Delivery.PrintAllShipments();
        }
    }
}