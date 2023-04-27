using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace FastWork.Models
{
    public partial class TaskOfDay : ObservableObject
    {
        [ObservableProperty]
        private string title;
        [ObservableProperty]
        private string[] task;
    }
}
