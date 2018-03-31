using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Task7
{
    class Stock
    {
        List<CarModification> ExistingCars = new List<CarModification>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute(this);
        }

        public void AddCar(CarModification car)
        {
            ExistingCars.Add(car);
        }

        public void DeleteCar(CarModification car)
        {
            ExistingCars.Remove(car);
        }

        public CarModification GetCar( int index )
        {
            return ExistingCars[index];
        }

        public void Serialise()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(CarModification[]));

            using (FileStream fs = new FileStream("Stock.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, ExistingCars);
            }
        }
    }
}
