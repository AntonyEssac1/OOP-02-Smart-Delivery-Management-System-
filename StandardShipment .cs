
namespace OOP_02___Smart_Delivery_Management_System
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        
           : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }
        
    }
}
