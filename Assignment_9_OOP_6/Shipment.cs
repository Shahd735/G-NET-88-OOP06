using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_OOP_6;

public abstract partial class Shipment
{
    private string _trackingCode;
    private string _description;
    private decimal _weight;
    private decimal _deliveryFee;
    private static int _totalShipmentsCreated;

    public string TrackingCode
    {
        get { return _trackingCode; }
        private set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _trackingCode = value;
            }
        }
    }

    public string Description
    {
        get { return _description; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _description = value;
            }
        }
    }

    public decimal Weight
    {
        get { return _weight; }
        set
        {
            if (value > 0)
            {
                _weight = value;
            }
        }
    }

    public decimal DeliveryFee
    {
        get { return _deliveryFee; }
        private set
        {
            if (value > 0)
            {
                _deliveryFee = value;
            }
        }
    }

    public DeliveryAddress Destination { get; set; }

    public abstract decimal EstimatedCost { get; }

    public Shipment(string trackingCode)
    {
        _trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN-CODE";

        _description = "Unknown";
        _weight = 1.0m;
        _deliveryFee = 50m;
        Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        _totalShipmentsCreated++;
    }

    public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
    {
        _trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN-CODE";
        _description = !string.IsNullOrWhiteSpace(description) ? description : "Unknown";
        _weight = weight > 0 ? weight : 1.0m;
        _deliveryFee = deliveryFee > 0 ? deliveryFee : 50m;

        Destination = destination;
        _totalShipmentsCreated++;
    }

    public void UpdateDeliveryFee(decimal newFee)
    {
        if (newFee > 0)
        {
            _deliveryFee = newFee;
        }
    }

    public abstract void PrintShipment();

    public void UpdateWeight(decimal newWeight)
    {
        Weight = newWeight;
    }

    public void UpdateWeight(decimal baseWeight, decimal extraPackingWeight)
    {
        Weight = baseWeight + extraPackingWeight;
    }

    public Shipment CopyShipment()
    {
        return (Shipment)this.MemberwiseClone();
    }

    public Shipment ShallowCopy()
    {
        return (Shipment)this.MemberwiseClone();
    }

    public Shipment DeepCopy()
    {
        Shipment clone = (Shipment)this.MemberwiseClone();

        clone.Destination = new DeliveryAddress(
            this.Destination.City,
            this.Destination.Street,
            this.Destination.BuildingNumber
        );

        return clone;
    }

    static Shipment()
    {
        _totalShipmentsCreated = 0;
        Console.WriteLine("Shipment System Initialized");
    }

    public static int GetTotalShipmentsCreated()
    {
        return _totalShipmentsCreated;
    }

    partial void OnTrackingStatusChanged(string newStatus)
    {
        Console.WriteLine($"Tracking status changed to: {newStatus}");
    }
}
