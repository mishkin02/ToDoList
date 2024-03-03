using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.ViewModel
{
    public class TaskItem : BaseViewModel
    {
        private bool _isDone;
        public bool IsDone
        {
            get { return _isDone; }
            set
            {
                if (_isDone != value)
                {
                    _isDone = value;
                    OnPropertyChanged(nameof(IsDone));
                }
            }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        public TaskItem(string description)
        {
            Description = description;
            IsDone = false;
        }

        public TaskItem()
        {
            Description = string.Empty;
            IsDone = false;
        }
    }
}
