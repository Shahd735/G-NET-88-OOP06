using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_OOP_6;

public class StandardShipment : Shipment, ITrackable, IInsurable
{
    public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
    }

    public override decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5); }
    }

    public override void PrintShipment()
    {
        Console.WriteLine("Standard Shipment\n");
        Console.WriteLine($"Tracking Code : {TrackingCode}");
        Console.WriteLine($"Description   : {Description}");
        Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
    }

    public string GetTrackingStatus()
    {
        return $"Shipment {TrackingCode} is Ready.";
    }

    public decimal CalculateInsurance()
    {
        return EstimatedCost * 0.05m;
    }
}
