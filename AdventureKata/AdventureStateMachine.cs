using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureKata
{
    public class AdventureStateMachine
    {
        public enum AdventureStates { INITIAL_STATE,AREYOUPREPARED_STATE, CAVE_STATE, HOLE_STATE, STREAM_STATE, NORTH_STATE, BEAR_STATE}

        public AdventureStates currentState;
        public string currentText;

        public AdventureStateMachine()
        {
            currentState = AdventureStates.INITIAL_STATE;
        }

        public void Input(string inputText)
        {
            inputText = inputText.ToLower();

            switch(currentState)
            {
                case AdventureStates.INITIAL_STATE:
                    if (!String.IsNullOrEmpty(inputText))
                        currentState = AdventureStates.AREYOUPREPARED_STATE;
                    break;

                case AdventureStates.AREYOUPREPARED_STATE:
                    if (inputText == "y")
                        currentState = AdventureStates.CAVE_STATE;
                        break;

                case AdventureStates.CAVE_STATE:
                   
                    if(inputText == "look")
                    {
                        currentText ="What are you looking at?";
                    }
                    else if(inputText =="look stream")
                    {
                        currentText = "Yeah, that hole is like 8 feet up.  And it's rather horrifying";
                        currentText += "But 8 feet, man.  And it's person-sized.  Wonder what's inside?";

                    }
                    else if(inputText =="look hole")
                    {
                        currentText ="Yeah, that hole is like 8 feet up.  And it's rather horrifying";
                        currentText +="But 8 feet, man.  And it's person-sized.  Wonder what's inside?";
                    }
                    else if(inputText == "jump")
                    {
                        currentText = "Good job!  You can jump.  That is, undoubtedly, impressive."; 
                    }
                    else if(inputText == "climb")
                    {
                        currentText = "What are you climbing?  There are a lot of rocks.";
                    }
                    else if(inputText == "climb hole")
                    {

                    }
                    else if(inputText == "drink")
                    {

                    }
                    else if(inputText == "drink apple juice")
                    {

                    }
                    else if (inputText == "go")
                    {
   
                    }
                    else if (inputText == "go north")
                    {
                        currentState = AdventureStates.BEAR_STATE; 
                    }
                    else if (inputText == "go")
                    {
                        currentState = AdventureStates.BEAR_STATE; 
                    }

                    break;

                case AdventureStates.HOLE_STATE:
                    break;

                case AdventureStates.STREAM_STATE:
                    break;

                case AdventureStates.NORTH_STATE:
                    break;

                case AdventureStates.BEAR_STATE:
                    break;
            }
                     
        }

        public AdventureStates GetState()
        {
            return currentState;
        }
    }
}
