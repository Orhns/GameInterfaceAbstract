using GameInterfaceAbstract.Abstract;
using GameInterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterfaceAbstract.Concrete
{
    public class GameProductManager : IGameProductService
    {
        public void Add(GameProduct gameProduct)
        {
            Console.WriteLine("Game product : " + gameProduct.Name + " is added.");
        }

        public void Delete(GameProduct gameProduct)
        {
            Console.WriteLine("Game product : " + gameProduct.Name + " is updated.");
        }

        public void Update(GameProduct gameProduct)
        {
            Console.WriteLine("Game product : " + gameProduct.Name + " is deleted.");
        }
    }
}
