using StudyList.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace StudyList.Core
{
    public class WorkTasksPageVievModel : BaseVievModel
    {
        public ObservableCollection<WorkTaskVievModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTaskVievModel>();

        public string NewWorkTaskTitle { get; set; }

        public string NewWorkTaskDescription { get; set; }

        public ICommand AddNewTaskCommand { get; set; }
        public ICommand DeleteSelectedTaskCommand { get; set; }


        public WorkTasksPageVievModel()
        {
            AddNewTaskCommand = new RelayCommand(AddNewTask);
            DeleteSelectedTaskCommand = new RelayCommand(DeleteSelectedTasks);

            foreach (var task in  DataBaseLocator.Database.WorkTasks.ToList())
            {
                WorkTaskList.Add(new WorkTaskVievModel
                {
                    Id = task.Id,
                    Title = task.Title,
                    Description = task.Description,
                    CreatedDate = task.CreateDate

                }); 
            }
        }


        private void AddNewTask()
        {
            var newTask = new WorkTaskVievModel
            {
                Title = NewWorkTaskTitle,

                Description = NewWorkTaskDescription,

                CreatedDate = DateTime.Now
            };

            WorkTaskList.Add(newTask);

            DataBaseLocator.Database.WorkTasks.Add(new Database.WorkTask 
            {
                Title = newTask.Title,
                Description = newTask.Description,
                CreateDate = newTask.CreatedDate
            });

            DataBaseLocator.Database.SaveChanges();

            NewWorkTaskTitle = string.Empty;

            NewWorkTaskDescription = string.Empty;
            OnPropertyChanged(nameof(NewWorkTaskTitle));
            OnPropertyChanged(nameof(NewWorkTaskDescription));

        }

        private void DeleteSelectedTasks()
        {
            var slectedTasks = WorkTaskList.Where(x => x.IsSelected).ToList();
            foreach(var task in slectedTasks)
            {
                WorkTaskList.Remove(task);

                var foundEntity = DataBaseLocator.Database.WorkTasks.FirstOrDefault(x => x.Id == task.Id);

                if(foundEntity != null)
                {
                    DataBaseLocator.Database.WorkTasks.Remove(foundEntity);
                }
            }
            DataBaseLocator.Database.SaveChanges();
        }
        
    }
}
