using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Task7
{
    [DataContract]
    abstract class CarModification
    {
        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public string Model { get; set; }
       
        public enum CarCase
        {
            Universal,
            Sedan,
            Minivan,
            Cupe

        }
        [DataMember]
        public CarCase Case { get; set; }

        public enum Transmission 
        {
            Manual,
            Automatic
        }
        [DataMember]
        public Transmission Transmissio { get; set; }

        public enum Engine
        {
            Petrol,
            Diesel,
            Electro
        }
        [DataMember]
        public Engine Engin { get; set; }

        [DataMember]
        public int Volume { get; set; }

        [DataMember]
        public int Power { get; set; }

        public enum ClimateControl
        {
            Conditioner,
            ClimateControl,
            No
        }
        [DataMember]
        public ClimateControl Climate { get; set; }

        public enum Upholstery
        {
            Lather,
            Textail,
            Mixed
        }
        [DataMember]
        public Upholstery Upholster { get; set; }
        
        public CarModification(string brand, string model, CarCase carCase, Transmission transmission, 
            Engine engine, int volume, int power, ClimateControl climateControl, Upholstery upholstery)
        {
            Brand = brand;
            Model = model;
            Case = carCase;
            Transmissio = transmission;
            Engin = engine;
            Volume = volume;
            Power = power;
            Climate = climateControl;
            Upholster = upholstery;
        }     
    }
}

