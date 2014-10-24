using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureKata
{
    public class AdventureStateMachine
    {
        private string currentState;

        public AdventureStateMachine()
        {
            currentState   = "             Atomic Coffee Proudly Presents THE ADVENTURE KATA ";
            currentState  += "\n                    : created and written by Princie :         ";
            currentState  += "\n                              with help from           ";
            currentState  += "\n             http://www.lincolnli.com/text-adventure-game---c.html         ";
        }


        public void Input(string p)
        {
            
        }

        public string GetState()
        {
            return currentState;
        }
    }
}
