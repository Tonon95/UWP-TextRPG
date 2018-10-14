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
            CELL_00, CELL_01, CELL_02, CELL_03, CELL_04, CELL_05,
            CORRIDOR_00, CORRIDOR_01, CORRIDOR_02
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

            // State 4: CELL_04

            // State 5: CELL_05





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
