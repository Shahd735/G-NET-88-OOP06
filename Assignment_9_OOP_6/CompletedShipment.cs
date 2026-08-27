using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_OOP_6;

public sealed class CompletedShipment : Shipment, ITrackable
{
    public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
    }

    public override decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5); }
    }

    public override void PrintShipment()
    {
        Console.WriteLine("--- Standard Shipment ---");
        Console.WriteLine($"Tracking Code:  {TrackingCode}");
        Console.WriteLine($"Description:    {Description}");
        Console.WriteLine($"Weight:         {Weight} kg");
        Console.WriteLine($"Delivery Fee:   {DeliveryFee}");
        Console.WriteLine($"Destination:    {Destination.GetFullAddress()}");
        Console.WriteLine($"Estimated Cost: {EstimatedCost}");
    }

    public string GetTrackingStatus()
    {
        return $"Shipment {TrackingCode} has been Delivered.";
    }
}
