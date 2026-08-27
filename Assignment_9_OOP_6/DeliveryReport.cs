using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_OOP_6;

public static class DeliveryReport
{
    public static void PrintShipment(ITrackable shipment)
    {
        Console.WriteLine(shipment.GetTrackingStatus());
    }

    public static void PrintInsurance(IInsurable shipment)
    {
        Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance()}");
    }
}
