using System;
using System.Collections.Generic;
using Todo_APP.Models;
using Todo_APP.Models.UtilityModels;

namespace Todo_APP.Interface
{
   public interface ITasksData
    {
        List<Tasks> GetTasks();

        Tasks GetTasks(Guid Id);

        Tasks AddTask(Tasks tasks);

        Tasks EditTask(Tasks tasks);

        void DeleteTask(Tasks tasks);

        void AssignedTaskTo(AssignedTo value);
    }
}
