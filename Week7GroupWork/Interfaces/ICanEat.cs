using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Interfaces
{
    public interface ICanEat
    {
        public int Hunger { get; set; }
        public void Eat();
    }
}
