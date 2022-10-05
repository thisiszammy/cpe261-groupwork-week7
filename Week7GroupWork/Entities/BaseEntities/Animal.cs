using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Animation;
using Week7GroupWork.Interfaces;

namespace Week7GroupWork.Entities.BaseEntities
{
    public abstract class Animal : ICanMove, ICanEat, ICanDrink
    {
        public double Velocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Thirst { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Hunger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Run(string name)
        {
            name ??= "Tom";
            string[] frames = { $"{name} is running.", $"{name} is running..", $"{name} is running...", $"{name} is running   " };
            TextAnimation.TextAnimation1(frames, 100);
        }
        public abstract void Back();

        public abstract double GetVelocity(double distance, double time);


        public void Drink()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

    }
}
