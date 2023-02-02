﻿using InputKit.Shared.Controls;
using UraniumUI.Pages;

namespace FitnestX;

public partial class MainPage : UraniumContentPage
{
	public MainPage()
    {
        SelectionView.GlobalSetting.CornerRadius = 0;
        InitializeComponent();
	}

	private void ShowBottomSheet(object sender, EventArgs e)
	{
		bottomSheet.IsPresented = true;
    }
}