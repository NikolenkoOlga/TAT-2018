using System;

namespace Task_7
{
    abstract class CarFactory
    {      
      public string Name { get; set; }
        /* Маркой;
·   	Моделью;
·   	Типом кузова(универсал, седан, минивен, купе);
·     Типом трасмиссии(ручная, автомат);
·   	Типом двигателя(бензин, дизель, электро);
·   	Обьемом;
·   	Мощностью;
·   	Управлением климатом(кондиционер, климат-контроль, нет);
·   	Типом салона(кожа, ткань, комбинированный)*/

        public CarFactory (string n)
      {
        Name = n;       
      }
      // фабричный метод
      abstract public Car Create();
    }

    // сосдать Москвич
    class Moskvich : CarFactory
     {
       public Moskvich(string n) : base(n)
       { }

      public override Car Create()
       {
         return new MoskvichCar();
       }
     }

    // сосдать Мазду
    class Mazda : CarFactory
    {
        public Mazda(string n) : base(n)
        { }

        public override Car Create()
        {
            return new MazdaCar();
        }
    }
    // создать Опель
    class Opel : CarFactory
    {
        public Opel(string n) : base(n)
        { }

        public override Car Create()
        {
            return new OpelCar();
        }
    }

    // сосдать Седан
    class Sedan : CarFactory
     {
       public Sedan(string n) : base(n)
       { }

       public override Car Create()
       {
         return new SedanCar();
       }
     }

     abstract class Car
    { }

    class MoskvichCar : Car
     {
       public MoskvichCar()
       {
            System.Console.WriteLine("This car is in stock");
       }
     }

    class MazdaCar : Car
    {
        public MazdaCar()
        {
            System.Console.WriteLine("This car is in stock");
        }
    }

    class OpelCar : Car
    {
        public OpelCar()
        {
            System.Console.WriteLine("This car is in stock");
        }
    }

    class SedanCar : Car
     {
       public SedanCar()
       {
            System.Console.WriteLine("This car is in stock");
       }
     } 
}
