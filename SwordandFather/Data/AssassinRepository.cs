using SwordandFather.Models;
using System.Collections.Generic;

namespace SwordandFather.Data
{
    internal class AssassinRepository
    {
        static readonly List<Assassin> Assassins = new List<Assassin>();

        public void AddAssassin(Assassin assassin)
        {
            assassin.Id = Assassins.Count + 1;
            Assassins.Add(assassin);
        }
    }
}