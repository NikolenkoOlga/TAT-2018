using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class AddCar : ICommand
    {
        CarModification c;
        public AddCar(CarModification car)
        {
            c = car;
        }
        public void Execute(Stock stock)
        {
            stock.AddCar(c);
        }
    }

    class DeleteCar : ICommand
    {
        CarModification c;
        public DeleteCar(CarModification car)
        {
            c = car;
        }
        public void Execute(Stock stock)
        {
            stock.DeleteCar(c);
        }
    }

    class GetCar : ICommand
    {
        int i;
        public GetCar(int index)
        {
            i = index;
        }
        public void Execute(Stock stock)
        {
            stock.GetCar(i);
        }
    }   
}

