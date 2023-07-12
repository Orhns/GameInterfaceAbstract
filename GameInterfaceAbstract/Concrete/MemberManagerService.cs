using GameInterfaceAbstract.Abstract;
using GameInterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterfaceAbstract.Concrete
{
    public class MemberManagerService : BaseMemberManager
    {
        IMemberCheckService _memberCheckService;

        public MemberManagerService(IMemberCheckService memberCheckService)
        {
            _memberCheckService = memberCheckService;
        }

        public override void Save(Member member)
        {
            if (_memberCheckService.CheckIfRealPerson(member))
            {
                base.Save(member);
            } else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
