﻿using Capstone.Common;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace Capstone
{
    /// <summary>
    /// The main page that is shown to the user when they open up the application
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private bool IsMenuExpanded = false;
        public MainPage()
        {
            this.InitializeComponent();
            // hide the main menu
            this.MenuColumn.Width = new GridLength(0);
            string ssmlText = new SSMLBuilder().Sentence("Hello, World!").Prosody("This is some prosody", contour: "(50%,+20%) (90%,-30%)").SayAs("6720 Wesselman Rd. Cleves, OH 45002", SSMLBuilder.SayAsTypes.ADDRESS).Build();
            TextToSpeechEngine.SpeakSSMLText(this.media, ssmlText);
        }

        private void MenuButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!this.IsMenuExpanded)
            {
                // show the menu column
                this.MenuColumn.Width = new GridLength(320);
            }
            else
            {
                this.MenuColumn.Width = new GridLength(0);
            }
            this.IsMenuExpanded = !this.IsMenuExpanded;
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO navigate to settings screen (this.Frame.Navigate(typeof(screenName)))
        }

        private void RemindersButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RemindersPage));
        }

        private void AlarmsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AlarmsPage));
        }

        private void VoiceNotesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VoiceMemosPage));
        }

        private void DataPrivacyButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DataPrivacyTips));
        }

        private void LibrariesButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO navigate to settings screen (this.Frame.Navigate(typeof(screenName)))
        }
    }
}
