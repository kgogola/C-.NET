using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BasketballService.Models;



 
namespace BasketballService.DAL
{
    public class TeamsInitializer : DropCreateDatabaseIfModelChanges<TeamsContext>
    {

        protected override void Seed(TeamsContext context) //nie wiem co to
        {
            SeedTeamsData(context);
            base.Seed(context);

        }




        public static void SeedTeamsData(TeamsContext context)
        {
            var teams = new List<Team>
            {
                new Team() { TeamId=1, TeamName="Kraków Lakers", NameOfLogoFile="Lakers", TeamDescription="This team contain a lot of great players" },
                new Team() { TeamId=2, TeamName="Katowice Bulls", NameOfLogoFile="Bulls", TeamDescription="Very young and talented team" },
                new Team() { TeamId=3, TeamName="Rzeszów Clippers", NameOfLogoFile="Clippers", TeamDescription="This team contain a lot of great players" },
                new Team() { TeamId=4, TeamName="Barcelona Nets", NameOfLogoFile="Nets", TeamDescription="Team with great history" },
                new Team() { TeamId=5, TeamName="Kraków Raptors", NameOfLogoFile="Raptors", TeamDescription="This team contain a lot of great players" },
                new Team() { TeamId=6, TeamName="Kraków Rockets", NameOfLogoFile="Rockets", TeamDescription="This team contain lack of great players" },
                new Team() { TeamId=7, TeamName="Kraków Suns", NameOfLogoFile="Suns", TeamDescription="This team contain a lot of great players" },
                new Team() { TeamId=8, TeamName="Kraków Thunders", NameOfLogoFile="Thunders", TeamDescription="This team contain a lot of great players" },
                new Team() { TeamId=9, TeamName="Zastal Kraków", NameOfLogoFile="Zastal", TeamDescription="Great polish team" },
                new Team() { TeamId=10, TeamName="Kraków Skulls", NameOfLogoFile="Skulls", TeamDescription="Some kind of creapy team" },
            };

            teams.ForEach(k => context.Teams.AddOrUpdate(k));
            context.SaveChanges();

            var players = new List<Player>
            {
                new Player() { PlayerId=1, PlayerName="Mariusz", PlayerSurname="Kowalski", PlayerPosition ="Center", TeamId = 1,
                                                                    NameOfPlayerPhotoFile =null,PlayerBornDate = new DateTime(1990,11,2), },
                new Player() { PlayerId=2, PlayerName="Tomasz", PlayerSurname="Poduszowski", PlayerPosition ="Small Forward", TeamId = 5,
                                                                            NameOfPlayerPhotoFile =null,PlayerBornDate = new DateTime(1990,11,2), },
                new Player() { PlayerId=3, PlayerName="Grzegorz", PlayerSurname="Nowak", PlayerPosition ="Center", TeamId = 1,
                                                                  NameOfPlayerPhotoFile =null,PlayerBornDate = new DateTime(1990,11,2), },
                new Player() { PlayerId=4, PlayerName="Szymon", PlayerSurname="Kowalski", PlayerPosition ="Point Guard", TeamId = 2,
                                                                         NameOfPlayerPhotoFile =null,PlayerBornDate = new DateTime(1990,11,2), },
                new Player() { PlayerId=4, PlayerName="Bolo", PlayerSurname="Kowal", PlayerPosition ="Point Guard", TeamId = 2,
                                                                         NameOfPlayerPhotoFile =null,PlayerBornDate = DateTime.Parse("12/5/1990"), },
                new Player() { PlayerId=9, PlayerName="Jan", PlayerSurname="Nowak", PlayerPosition ="Point Guard", TeamId = 4,
                                                                         NameOfPlayerPhotoFile =null,PlayerBornDate = DateTime.Parse("12/5/1990"), },
            };

            players.ForEach(k => context.Players.AddOrUpdate(k));
            context.SaveChanges();



        }

    }
}

