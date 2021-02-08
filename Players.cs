using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed
{
     class Avi : Bettor
    {
        public Avi(Bet MyBet, Label MaximumBet, int Money, Label MyLabel) : base(MyBet, MaximumBet, Money, MyLabel)
        {
            Title = "Amrit";
        }
    }

     class Vicky : Bettor
    {
        public Vicky(Bet bet, Label MaximumBet, int Money, Label label) : base(bet, MaximumBet, Money, label)
        {
            Title = "Vicky";
        }
    }

     class Anmol : Bettor
    {
        public Anmol(Bet bet, Label MaximumBet, int Money, Label label) : base(bet, MaximumBet, Money, label)
        {
            Title = "Anmol";
        }

    }
}
