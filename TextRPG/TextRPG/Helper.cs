using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Helper
    {
        public enum GameState
        {
            CELL_00, CELL_01, CELL_02, CELL_03, CELL_04, CELL_05, CELL_06, CELL_07,
            CORRIDOR_00
        }


        public struct GameStateElem
        {
            public string StateDescription_Text;
            public string ActionButtonOne_Text;
            public string ActionButtonTwo_Text;

            public int PressedOne_NextState;
            public int PressedTwo_NextState;

            public GameState CurrentGameState;
        }


        private static string _stateDescription_Text;
        private static string _actionButtonOne_Text;
        private static string _actionButtonTwo_Text;

        private static int _ifActionButtonOne_NextState;
        private static int _ifActionButtonTwo_NextState;

        private static GameState _currentGameState;

        private static int _currentStateIndex;
        public static int CurrentStateIndex { get => _currentStateIndex; set => _currentStateIndex = value; }


        public static List<GameStateElem> GameStateList;


        public static void InitializeStringConstants()
        {
            // Initializing GameStateElem List
            GameStateList = new List<GameStateElem>();


            // State 1: CELL_00
            _stateDescription_Text = "You wake up inside of a prison cell.\n" +
                                       "Having no idea of what happened to you or whom caused this fate upon you, " +
                                       "your eyes begin to wander through the 4x4 space that you find yourself in.";
            _actionButtonOne_Text = "Look Left";
            _actionButtonTwo_Text = "Look Right";
            _ifActionButtonOne_NextState = (int)GameState.CELL_01;
            _ifActionButtonTwo_NextState = (int)GameState.CELL_02;
            _currentGameState = GameState.CELL_00;

            AddNewGameStateElem(_stateDescription_Text, _actionButtonOne_Text, _actionButtonTwo_Text,
                                _ifActionButtonOne_NextState, _ifActionButtonTwo_NextState, _currentGameState);


            // State 2: CELL_01
            _stateDescription_Text = "You turn left.\n" +
                                     "Well, well, well, who knew? There is a wall there! " +
                                     "Oh, wait, you also see an aquarium with a piranha... And...\n" +
                                     "Yeap, there is the key, yay.";
            _actionButtonOne_Text = "Keep Staring";
            _actionButtonTwo_Text = "Go Back";
            _ifActionButtonOne_NextState = (int)GameState.CELL_01;
            _ifActionButtonTwo_NextState = (int)GameState.CELL_00;
            _currentGameState = GameState.CELL_01;

            AddNewGameStateElem(_stateDescription_Text, _actionButtonOne_Text, _actionButtonTwo_Text,
                                _ifActionButtonOne_NextState, _ifActionButtonTwo_NextState, _currentGameState);


            // State 2: CELL_02
            _stateDescription_Text = "You turn right.\n" +
                                     "There is a plate of food on a desk. " +
                                     "The food seems ok, but you would rather not eat something made in here...";
            _actionButtonOne_Text = "Take Plate";
            _actionButtonTwo_Text = "Go Back";
            _ifActionButtonOne_NextState = (int)GameState.CELL_03;
            _ifActionButtonTwo_NextState = (int)GameState.CELL_00;
            _currentGameState = GameState.CELL_02;

            AddNewGameStateElem(_stateDescription_Text, _actionButtonOne_Text, _actionButtonTwo_Text,
                                _ifActionButtonOne_NextState, _ifActionButtonTwo_NextState, _currentGameState);


            // State 3: CELL_03
            _stateDescription_Text = "Well, now you are holding a plate of food.\n" +
                                     "Great, now you can fit in at the prison dinner... Nah, just kidding, that was two months ago.\n" +
                                     "What do you wanna do now that you have this?";
            _actionButtonOne_Text = "Turn Left";
            _actionButtonTwo_Text = "Stay Here";
            _ifActionButtonOne_NextState = (int)GameState.CELL_04;
            _ifActionButtonTwo_NextState = (int)GameState.CELL_03;
            _currentGameState = GameState.CELL_03;

            AddNewGameStateElem(_stateDescription_Text, _actionButtonOne_Text, _actionButtonTwo_Text,
                                _ifActionButtonOne_NextState, _ifActionButtonTwo_NextState, _currentGameState);

            // State 4: CELL_04
            _stateDescription_Text = "The piranha is still in the aquarium, right above the keys.\n" +
                                     "Any ideas?";
            _actionButtonOne_Text = "Use Food";
            _actionButtonTwo_Text = "Eat Food";
            _ifActionButtonOne_NextState = (int)GameState.CELL_05;
            _ifActionButtonTwo_NextState = (int)GameState.CELL_06;
            _currentGameState = GameState.CELL_04;

            AddNewGameStateElem(_stateDescription_Text, _actionButtonOne_Text, _actionButtonTwo_Text,
                                _ifActionButtonOne_NextState, _ifActionButtonTwo_NextState, _currentGameState);


            // State 5: CELL_05
            _stateDescription_Text = "You shared your plate of food with the piranha. It's happy and now you are BFFs.\n" +
                                     "The piranha gives you the key to your cell.";
            _actionButtonOne_Text = "Chat";
            _actionButtonTwo_Text = "Go Back";
            _ifActionButtonOne_NextState = (int)GameState.CELL_05;
            _ifActionButtonTwo_NextState = (int)GameState.CELL_07;
            _currentGameState = GameState.CELL_05;

            AddNewGameStateElem(_stateDescription_Text, _actionButtonOne_Text, _actionButtonTwo_Text,
                                _ifActionButtonOne_NextState, _ifActionButtonTwo_NextState, _currentGameState);


            // State 6: CELL_06
            _stateDescription_Text = "You eat food in front of the piranha. The piranha seems pretty annoyed.";
            _actionButtonOne_Text = "Use Food";
            _actionButtonTwo_Text = "Eat Food";
            _ifActionButtonOne_NextState = (int)GameState.CELL_05;
            _ifActionButtonTwo_NextState = (int)GameState.CELL_06;
            _currentGameState = GameState.CELL_06;

            AddNewGameStateElem(_stateDescription_Text, _actionButtonOne_Text, _actionButtonTwo_Text,
                                _ifActionButtonOne_NextState, _ifActionButtonTwo_NextState, _currentGameState);


            // State 7: CELL_07
            _stateDescription_Text = "You are now in the center of the cell with the key to your freedom... Kind of.\n" +
                                     "Now what?";
            _actionButtonOne_Text = "Use Key";
            _actionButtonTwo_Text = "Stay Here";
            _ifActionButtonOne_NextState = (int)GameState.CORRIDOR_00;
            _ifActionButtonTwo_NextState = (int)GameState.CELL_07;
            _currentGameState = GameState.CELL_07;


            AddNewGameStateElem(_stateDescription_Text, _actionButtonOne_Text, _actionButtonTwo_Text,
                                _ifActionButtonOne_NextState, _ifActionButtonTwo_NextState, _currentGameState);



            // State 8: CORRIDOR_00 (FINAL STATE OF THE PROTOTYPE)
            _stateDescription_Text = "You are now outside your cell. You are going to miss Frank, the piranha.\n" +
                                     "You know you are going to see each other again when you figure out what's happening. But... " +
                                     "Where are we?";
            _actionButtonOne_Text = "Restart";
            _actionButtonTwo_Text = "Do Nothing";
            _ifActionButtonOne_NextState = (int)GameState.CELL_00;
            _ifActionButtonTwo_NextState = (int)GameState.CORRIDOR_00;
            _currentGameState = GameState.CORRIDOR_00;


            AddNewGameStateElem(_stateDescription_Text, _actionButtonOne_Text, _actionButtonTwo_Text,
                                _ifActionButtonOne_NextState, _ifActionButtonTwo_NextState, _currentGameState);




        }



        public static void AddNewGameStateElem(string description, string actionButton1, string actionButton2,
                                        int ifOneNextState, int ifTwoNextState, GameState gameState)
        {
            var newGameState = new GameStateElem();

            newGameState.StateDescription_Text = description;
            newGameState.ActionButtonOne_Text = actionButton1;
            newGameState.ActionButtonTwo_Text = actionButton2;
            newGameState.PressedOne_NextState = ifOneNextState;
            newGameState.PressedTwo_NextState = ifTwoNextState;
            newGameState.CurrentGameState = gameState;


            GameStateList.Add(newGameState);
        }



        public static void SetCurrentGameState(int actionNum)
        {
            switch(actionNum)
            {
                case 1:
                    CurrentStateIndex = GameStateList.ElementAt(CurrentStateIndex).PressedOne_NextState;
                    break;

                case 2:
                    CurrentStateIndex = GameStateList.ElementAt(CurrentStateIndex).PressedTwo_NextState;
                    break;
            }
        }

        
    }
}
