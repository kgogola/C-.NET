using BasketballService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BasketballService.DAL
{
    public class TeamsContext : DbContext
    {
        public TeamsContext() : base("TeamsContext") //nazwa connectionStringa
        {

        }

        static TeamsContext()
        {
            Database.SetInitializer<TeamsContext>(new TeamsInitializer());
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        //NIE WIEM DO CZEGO TO SŁUŻYŁO???????????????????????????????????????????????
        //protected override void OnModelCreating(DbModelBuilder modelBuilder) // w momencie tworzenia bazy zmienia sie konwencja
        //{
        //    base.OnModelCreating(modelBuilder);

        //    //To Wyłącza konwencje tych angielskich nazw z dodawaniem "S" na koncu 
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}


    }
}