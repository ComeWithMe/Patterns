using System;

namespace Patterns
{
    interface IMovable
    {
        void Move();
    }

    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("PetrolMove");
        }
    }

    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine(GetType().Name);
        }
    }
    class Car
    {
        protected int Passengers; // кол-во пассажиров
        protected string Model; // модель автомобиля

        public Car(int num, string model, IMovable mov)
        {
            this.Passengers = num;
            this.Model = model;
            Movable = mov;
        }
        public IMovable Movable { private get; set; }
        public void Move()
        {
            Movable.Move();
        }
    }
}
