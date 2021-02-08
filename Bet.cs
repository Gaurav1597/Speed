using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
     class Bet
    {
        public int Amount;
        public int DogNum;
        public Bettor Bettor;

        public Bet(int Amount, int DogNum, Bettor Bettor)
        {
            this.Amount = Amount;
            this.DogNum = DogNum;
            this.Bettor = Bettor;
        }
        public string GetDescription()
        {
            string description;
            if (Amount > 0)
            {
                description = string.Format("{0} bets {1} on Dragon #{2}",
                    Bettor.Title, Amount, DogNum);
            }
            else
            {
                description = string.Format("{0} hasn't placed any bets",
                    Bettor.Title);
            }
            return description;
        }

        public int Pay(int Winner)
        {
            if (DogNum == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
