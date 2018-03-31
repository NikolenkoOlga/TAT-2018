using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task7.CarModification;

namespace Task7
{
    abstract class CarFactory
    {
        // public string Name { get; set; }
        /* Маркой;
·   	Моделью;
·   	Типом кузова(универсал, седан, минивен, купе);
·     Типом трасмиссии(ручная, автомат);
·   	Типом двигателя(бензин, дизель, электро);
·   	Обьемом;
·   	Мощностью;
·   	Управлением климатом(кондиционер, климат-контроль, нет);
·   	Типом салона(кожа, ткань, комбинированный)*/

        /*public CarFactory(string n)
        {
            Name = n;
        }*/
        // фабричный метод
        abstract public CarModification Create(string model, CarCase carCase, Transmission transmission,
            Engine engine, int volume, int power, ClimateControl climateControl,
            Upholstery upholstery);
    }

    // сосдать Москвич
    class MoskvichFactory : CarFactory
    {
        public MoskvichFactory() : base()
        { }

        public override CarModification Create(string model, CarCase carCase, Transmission transmission,
            Engine engine, int volume, int power, ClimateControl climateControl,
            Upholstery upholstery)
        {
            return new MoskvichCar(model, carCase, transmission, engine, volume, power, 
                climateControl, upholstery);
        }
    }

    // сосдать Мазду
    class MazdaFactory : CarFactory
    {
        public MazdaFactory() : base()
        { }

        public override CarModification Create(string model, CarCase carCase, Transmission transmission,
            Engine engine, int volume, int power, ClimateControl climateControl,
            Upholstery upholstery)
        {
            return new MazdaCar(model, carCase, transmission, engine, volume, power,
                climateControl, upholstery);
        }
    }
    // создать Опель
    class OpelFactory : CarFactory
    {
        public OpelFactory() : base()
        { }

        public override CarModification Create(string model, CarCase carCase, Transmission transmission,
            Engine engine, int volume, int power, ClimateControl climateControl,
            Upholstery upholstery)
        {
            return new OpelCar(model, carCase, transmission, engine, volume, power,
                climateControl, upholstery);
        }
    }

    // сосдать Киа
    class KiaFactory : CarFactory
    {
        public KiaFactory() : base()
        { }

        public override CarModification Create(string model, CarCase carCase, Transmission transmission,
            Engine engine, int volume, int power, ClimateControl climateControl,
            Upholstery upholstery)
        {
            return new KiaCar(model, carCase, transmission, engine, volume, power,
                climateControl, upholstery);
        }
    }

    class MoskvichCar : CarModification
    {
        public MoskvichCar(string model, CarCase carCase, Transmission transmission,
            Engine engine, int volume, int power, ClimateControl climateControl, Upholstery upholstery)
            : base ("Moskvich", model, carCase, transmission, engine, volume, power, climateControl, upholstery)
        {
            System.Console.WriteLine("This car is in stock");
        }
    }

    class MazdaCar : CarModification
    {
        public MazdaCar(string model, CarCase carCase, Transmission transmission,
            Engine engine, int volume, int power, ClimateControl climateControl, Upholstery upholstery)
            : base("Mazda", model, carCase, transmission, engine, volume, power, climateControl, upholstery)
        {
            System.Console.WriteLine("This car is in stock");
        }
    }

    class OpelCar : CarModification
    {
        public OpelCar(string model, CarCase carCase, Transmission transmission,
            Engine engine, int volume, int power, ClimateControl climateControl, Upholstery upholstery)
            : base("Opel", model, carCase, transmission, engine, volume, power, climateControl, upholstery)
        {
            System.Console.WriteLine("This car is in stock");
        }
    }

    class KiaCar : CarModification
    {
        public KiaCar(string model, CarCase carCase, Transmission transmission,
            Engine engine, int volume, int power, ClimateControl climateControl, Upholstery upholstery)
            : base("Kia", model, carCase, transmission, engine, volume, power, climateControl, upholstery)
        {
            System.Console.WriteLine("This car is in stock");
        }
    }
}