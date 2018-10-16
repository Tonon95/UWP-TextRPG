using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace TextRPG
{
    /// <summary>
    /// Page that shows the content of the game, such as location of the player in world,
    /// description of his/her current state and arounds and two action buttons.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        public GamePage()
        {
            this.InitializeComponent();
        }


        private void OnGamePage_Loaded(object sender, RoutedEventArgs e)
        {
            Helper.InitializeStringConstants();
            ChangeTextElementsInGame();
        }


        private void ActionButton1_Click(object sender, RoutedEventArgs e)
        {
            Helper.SetCurrentGameState(1);
            ChangeTextElementsInGame();
        }


        private void ActionButton2_Click(object sender, RoutedEventArgs e)
        {
            Helper.SetCurrentGameState(2);
            ChangeTextElementsInGame();
        }


        private void ChangeTextElementsInGame()
        {
            // Getting Current GameStateElem to use
            Helper.GameStateElem currentElem = Helper.GameStateList.ElementAt(Helper.CurrentStateIndex);

            // Changing the location text using the GameState name
            string currentStateName = currentElem.CurrentGameState.ToString();
            string[] currentStateNameSplitted = currentStateName.Split('_');
            string location = currentStateNameSplitted[0].First().ToString().ToUpper() + currentStateNameSplitted[0].Substring(1).ToLower();

            CurrentLocationTextBlock.Text = location;


            // Changing texts using the GameStateElem struct fields
            StateDescriptionTextBlock.Text = currentElem.StateDescription_Text;
            ActionButton1.Content = currentElem.ActionButtonOne_Text;
            ActionButton2.Content = currentElem.ActionButtonTwo_Text;
        }
    }

    
    
}
