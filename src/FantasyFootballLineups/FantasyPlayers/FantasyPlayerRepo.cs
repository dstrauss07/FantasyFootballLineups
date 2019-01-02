using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDA.FantasyPlayers
{
    public class FantasyPlayerRepo
    {
        private static List<FantasyPlayers> _fPlayers = new List<FantasyPlayers>();

        private static int nextId = 0;

        public List<FantasyPlayers> ListAll()
        {
            return _fPlayers;
        }

        public FantasyPlayers GetById(int id)
        {
            return _fPlayers.Find(b => b.Id == id);

        }

        public void Add(FantasyPlayers newPlayer)
        {
            newPlayer.Id = nextId++;
            _fPlayers.Add(newPlayer);
        }

        public void Edit(FantasyPlayers editPlayer)
        {
            var origPlayer = GetById(editPlayer.Id);

            origPlayer.FirstName = editPlayer.FirstName;
            origPlayer.LastName = editPlayer.LastName;
            origPlayer.Position = editPlayer.Position;
            origPlayer.Team = editPlayer.Team;
            origPlayer.Age = editPlayer.Age;
        }

        public void Delete(int id)
        {
            var playerToDelete = GetById(id);
            _fPlayers.Remove(playerToDelete);
        }
    }
}
