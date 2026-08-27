using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_OOP_6;

public class DeliveryAddress
{
    public string City;
    public string Street;
    public int BuildingNumber;

    public DeliveryAddress(string city, string street, int buildingNumber)
    {
        City = city;
        Street = street;
        BuildingNumber = buildingNumber;
    }

    public string GetFullAddress()
    {
        return $"Building {BuildingNumber}, {Street} , {City}";
    }
}
