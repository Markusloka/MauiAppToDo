﻿namespace MauiAppToDo;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            Counter.Text = $"{count}";
 
     
        else
            Counter.Text = $" {count}";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}