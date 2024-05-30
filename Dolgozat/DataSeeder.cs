using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dolgozat.Migration;

namespace Dolgozat
{
    public static class DataSeeder
    {
        public static void SeedData(DbContext context)
        {
            if (!context.People.Any())
            {
                var people = new List<Datas>
            {
                new Datas { Name = "John", Age = 28, Nationality = "Amerikai", Occupation = "Fejlesztő", Interests = "Fotózás, Olvasás" },
                new Datas { Name = "Jane", Age = 35, Nationality = "Kanadai", Occupation = "Grafikus", Interests = "Éneklés, Horgászat" },
                new Datas { Name = "Alice", Age = 42, Nationality = "Brit", Occupation = "Író", Interests = "Kerékpározás, Kreatív írás" },
                new Datas { Name = "Michael", Age = 39, Nationality = "Ausztrál", Occupation = "Menedzser", Interests = "Főzés, Utazás" },
                new Datas{ Name = "Emily", Age = 29, Nationality = "Német", Occupation = "Művész", Interests = "Festés, Színház" },
                new Datas { Name = "David", Age = 45, Nationality = "Koreai", Occupation = "Tanár", Interests = "Futás, Hegymászás" },
                new Datas { Name = "Sophia", Age = 33, Nationality = "Japán", Occupation = "Dizájner", Interests = "Olvasás, Zenehallgatás" },
                new Datas { Name = "Daniel", Age = 36, Nationality = "Kínai", Occupation = "Üzletember", Interests = "Golf, Sakk" },
                new Datas { Name = "Olivia", Age = 31, Nationality = "Taiwani", Occupation = "Diplomata", Interests = "Kertészkedés, Íjászat" },
                new Datas { Name = "Ethan", Age = 27, Nationality = "Hongkongi", Occupation = "Pénzügyi tanácsadó", Interests = "Kajakozás, Hegymászás" }
            };

                context.People.AddRange(people);
                context.SaveChanges();
            }
        }
    }
}
