using GameInterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterfaceAbstract.Abstract
{
    public interface IChartService
    {
        void AddToChart(Member member, List<GameProduct> gameProducts);
        void RemoveFromChart(Member member, List<GameProduct> gameProducts);
    }
}
