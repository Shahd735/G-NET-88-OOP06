using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_OOP_6
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            string status = "Unknown Status";
            if (shipment is ITrackable trackableShipment)
            {
                status = trackableShipment.GetTrackingStatus();
            }

            string shipmentType = shipment.GetType().Name.Replace("Shipment", "");

            return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} KG | {status}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment is ITrackable trackableShipment)
            {
                return trackableShipment.GetTrackingStatus().Contains("Delivered");
            }

            return false;
        }
    }
}
