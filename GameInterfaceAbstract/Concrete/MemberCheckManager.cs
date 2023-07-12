using GameInterfaceAbstract.Abstract;
using GameInterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterfaceAbstract.Concrete
{
    internal class MemberCheckManager : IMemberCheckService
    {
        public bool CheckIfRealPerson(Member member)
        {
            return true;
        }
    }
}
