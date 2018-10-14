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

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace TextRPG
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
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
            
            StateDescriptionTextBlock.Text = Helper.GameStateList.ElementAt(0).StateDescription_Text;
            ActionButton1.Content = Helper.GameStateList.ElementAt(0).ActionButtonOne_Text;
            ActionButton2.Content = Helper.GameStateList.ElementAt(0).ActionButtonTwo_Text;
        }


        private void ActionButton1_Click(object sender, RoutedEventArgs e)
        {
            Helper.SetCurrentGameState(1);
            
            StateDescriptionTextBlock.Text = Helper.GameStateList.ElementAt(Helper.CurrentStateIndex).StateDescription_Text;
            ActionButton1.Content = Helper.GameStateList.ElementAt(Helper.CurrentStateIndex).ActionButtonOne_Text;
            ActionButton2.Content = Helper.GameStateList.ElementAt(Helper.CurrentStateIndex).ActionButtonTwo_Text;
        }


        private void ActionButton2_Click(object sender, RoutedEventArgs e)
        {
            Helper.SetCurrentGameState(2);

            StateDescriptionTextBlock.Text = Helper.GameStateList.ElementAt(Helper.CurrentStateIndex).StateDescription_Text;
            ActionButton1.Content = Helper.GameStateList.ElementAt(Helper.CurrentStateIndex).ActionButtonOne_Text;
            ActionButton2.Content = Helper.GameStateList.ElementAt(Helper.CurrentStateIndex).ActionButtonTwo_Text;
        }
    }

    
    
}
