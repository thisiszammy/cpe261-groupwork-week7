using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Interfaces;

namespace Week7GroupWork.Entities.BaseEntities
{
    public abstract class Animal : ICanMove, ICanEat, ICanDrink
    {
        public double Velocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Thirst { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Hunger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Back()
        {
            throw new NotImplementedException();
        }

        public void Drink()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public double GetVelocity()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
