using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed
{
    internal static class PlayerFactory
    {
        public static Bettor GetBettor(String Name, Label MaximumBet, Label bet)
        {
            Bettor b;
            switch (Name)
            {
                case "Amrit":
                    b = new Avi(null, MaximumBet, 50, bet);
                    break;

                case "Anmol":
                    b = new Anmol(null, MaximumBet, 50, bet);
                    break;

                case "Vicky":
                    b = new Vicky(null, MaximumBet, 50, bet);
                    break;

                default:
                    b = null;
                    break;
            }

            return b;
        }
    }
}
