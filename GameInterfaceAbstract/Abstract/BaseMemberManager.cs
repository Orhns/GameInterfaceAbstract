using GameInterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterfaceAbstract.Abstract
{
    public abstract class BaseMemberManager : IMemberService
    {
        public virtual void Save(Member member)
        {
            Console.WriteLine("Member " + member.FirstName + " " + member.LastName + " saved to db.");
        }

        public void Update(Member member)
        {
            Console.WriteLine("Member " + member.FirstName + " updated.");
        }
        public void Delete(Member member)
        {
            Console.WriteLine("Member " + member.FirstName + " deleted.");
        }
    }
}
