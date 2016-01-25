using BasketballRoster.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace BasketballRoster.ViewModel
{
    class RosterViewModel
    {
        private string _teamName;
        public string TeamName
        {
            get { return _teamName; }
            set
            {
                _teamName = value;
            }
        }

        public ObservableCollection<PlayerViewModel> Starters { get; set; }
        public ObservableCollection<PlayerViewModel> Bench { get; set; }

        private Roster _roster;

        public RosterViewModel(Roster roster)
        {
            _roster = roster;

            Starters = new ObservableCollection<PlayerViewModel>();
            Bench = new ObservableCollection<PlayerViewModel>();
            TeamName = _roster.TeamName;

            UpdateRosters();
        }

        private void UpdateRosters()
        {
            var startingPlayers =
                from player in _roster.Players
                where player.Starter == true
                select player;

            foreach (Player player in startingPlayers)
            {
                Starters.Add(new PlayerViewModel(player.Name, player.Number));
            }

            var benchPlayers =
                from player in _roster.Players
                where player.Starter == false
                select player;

            foreach (Player player in benchPlayers)
            {
                Bench.Add(new PlayerViewModel(player.Name, player.Number));
            }
        }
    }
}
