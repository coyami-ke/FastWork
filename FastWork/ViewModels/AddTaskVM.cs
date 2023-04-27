using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using FastWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace FastWork.ViewModels
{
    public partial class AddTaskVM : ObservableObject
    {
        [RelayCommand]
        private void AddTask()
        {
            WeakReferenceMessenger.Default.Send<AddTaskMessage>(new AddTaskMessage(new TaskOfDay { Title = this.Title }));
        }
        [ObservableProperty]
        private string title;
    }

    public class AddTaskMessage : ValueChangedMessage<TaskOfDay>
    {
        public AddTaskMessage(TaskOfDay value): base(value)
        {

        }
    }
}
