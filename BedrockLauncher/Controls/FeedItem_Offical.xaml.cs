﻿using System.Windows;
using System.Windows.Controls;
using BedrockLauncher.Classes.Launcher;

namespace BedrockLauncher.Controls
{
    /// <summary>
    /// Interaction logic for FeedItem_Offical.xaml
    /// </summary>
    public partial class FeedItem_Offical : Button
    {
        public FeedItem_Offical()
        {
            InitializeComponent();
        }

        public static void LoadArticle(NewsItem item)
        {
            JemExtensions.WebExtensions.LaunchWebLink(item.Link);
        }

        private void FeedItemEntry_Click(object sender, RoutedEventArgs e)
        {
            NewsItem item = this.DataContext as NewsItem;
            LoadArticle(item);
        }
    }
}