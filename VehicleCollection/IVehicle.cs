﻿
namespace GarageDI.Entities
{
    public interface IVehicle
    {
        object this[string name] { get; set; }
        string Color { get; set; }
        string RegNo { get; set; }
        string Print();
    }
}