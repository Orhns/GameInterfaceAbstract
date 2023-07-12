using GameInterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterfaceAbstract.Abstract
{
    public interface IGameProductService
    {
        void Add(GameProduct gameProduct);
        void Update(GameProduct gameProduct);
        void Delete(GameProduct gameProduct);
    }
}
