using GameInterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterfaceAbstract.Abstract
{
    public interface IMemberService
    {
        void Save(Member member);
        void Update(Member member);
        void Delete(Member member);
    }
}
