using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FastWork.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace FastWork.ViewModels
{
    public partial class MainVM : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<TaskOfDay> tasks;
        [ObservableProperty]
        private TaskOfDay selectedTask;
        [RelayCommand]
        private void AddTask()
        {

        }
    }
}
