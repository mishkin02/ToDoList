using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ToDoList.Model;

namespace ToDoList.ViewModel
{
    public partial class ToDoListViewModel : BaseViewModel
    {

        public ObservableCollection<TaskItem> TaskList  { get; } = new();
        public Command AddTaskCommand { get; }
        public Command DeleteTaskCommand { get; }
        public Command DoneTaskCommand { get; }

        private string _newTaskDescription = "";
        public string NewTaskDescription
        {
            get => _newTaskDescription;
            set
            {
                if (_newTaskDescription != value)
                {
                    _newTaskDescription = value;
                    OnPropertyChanged();
                }
            }
           
        }

     
        public ToDoListViewModel()
        {
            Title = "ToDoList";
            AddTaskCommand = new Command(AddTask);
            DeleteTaskCommand = new Command<TaskItem>(DeleteTask);
            DoneTaskCommand = new Command<TaskItem>(DoneTask);
        }

        void DoneTask(TaskItem task)
        {
            task.IsDone = true;
            OnPropertyChanged();
        }

        void AddTask()
        {
            if (NewTaskDescription != "")
            {
                TaskList.Add(new TaskItem(NewTaskDescription));
                NewTaskDescription = "";
            }
        }



        void DeleteTask(TaskItem task)
        {
            TaskList.Remove(task);
        }
    }
}
