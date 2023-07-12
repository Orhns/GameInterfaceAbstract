using GameInterfaceAbstract.Abstract;
using GameInterfaceAbstract.Adapters;
using GameInterfaceAbstract.Concrete;
using GameInterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterfaceAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member
            {
                Id = 1,
                FirstName = "Orhun",
                LastName = "Kırkağaçlıoğlu",
                DateOfBirth = new DateTime(1995, 4, 20),
                NationalityId = "31018148286",
                Email = "test@gmail.com"
            };
            GameProduct gameProduct1 = new GameProduct
            {
                Id= 1,
                Name= "GTA",
                Price = 20,
            };
            GameProduct gameProduct2 = new GameProduct
            {
                Id = 2,
                Name = "SIMS",
                Price = 6,
            };
            Campaign campaign1 = new Campaign
            {
                Id = 1,
                Name = "Summer Sale",
                DiscountPercentage = 20
            };

            BaseMemberManager memberManager = new MemberManagerService(new Adapters.MernisServiceAdapter());
            memberManager.Save(member1);
            //memberManager.Save(new Entities.Member { Id = 1, FirstName = "Orhun", LastName = "Kırkağaçlıoğlu", DateOfBirth = new DateTime(1995, 4, 20), NationalityId = "31018148286", Email = "sBob@gmail.com" });
            //memberManager.Update(new Entities.Member { FirstName = "Sponge"});


            ChartManagerService chartManagerService = new ChartManagerService();
            chartManagerService.AddToChart(member1,new List<GameProduct> { gameProduct1, gameProduct2}, campaign1);
            //chartManagerService.RemoveFromChart(member1, new List<GameProduct> { gameProduct1});
        }
    }
}
