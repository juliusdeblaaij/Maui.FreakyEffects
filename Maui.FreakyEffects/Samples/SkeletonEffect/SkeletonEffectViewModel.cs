﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Samples.SkeletonEffect;

public class SkeletonEffectViewModel : FreakyBaseViewModel
{
    const string title = "";

    public ICommand BackButtonCommand { get; }

    public SkeletonEffectViewModel()
    {
        BackButtonCommand = new Command(ExecuteOnBackButtonClicked);
    }

    private async void ExecuteOnBackButtonClicked()
    {
        await Shell.Current.Navigation.PopAsync();
    }
}