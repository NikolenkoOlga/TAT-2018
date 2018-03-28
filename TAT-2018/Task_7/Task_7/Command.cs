using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Command
    {
    }

    interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Receiver - Получатель
    class ConsoleMenu
    {
       public void Input()
        {
            Console.WriteLine("Телевизор включен!");
        }
    }

    class CarInCommand : ICommand
    {
        ConsoleMenu c;
        public CarInCommand(ConsoleMenu car)
        {
            c = car;
        }
        public void Execute()
        {
            c.On();
        }
        public void Undo()
        {
            c.Off();
        }
    }

    // Invoker - инициатор
    class Pult
    {
        ICommand command;

        public Pult() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PressButton()
        {
            command.Execute();
        }
        public void PressUndo()
        {
            command.Undo();
        }
    }
}
