using GameInterfaceAbstract.Abstract;
using GameInterfaceAbstract.Entities;
using GameInterfaceAbstract.MernisServiceAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterfaceAbstract.Adapters
{
    public class MernisServiceAdapter : IMemberCheckService
    {
        public bool CheckIfRealPerson(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(long.Parse(member.NationalityId), member.FirstName, member.LastName, member.DateOfBirth.Year);
        }
    }
}
