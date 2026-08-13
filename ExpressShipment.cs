

namespace OOP_02___Smart_Delivery_Management_System
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;

        /*
         * Requirements:
            ExtraFee must be greater than or equal to 0.
            Override the EstimatedCost property to include the extra fee.

        */

        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                
                    extraFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }


        public ExpressShipment(
         string trackingCode,
         string description,
         decimal weight,
         decimal deliveryFee,
         DeliveryAddress destination,
         decimal extraFee)
         : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

    }
}
