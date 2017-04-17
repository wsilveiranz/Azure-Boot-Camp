using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MyTasks.API.Models;
using MyTasks.API.Repository;

namespace MyTasks.API.Controllers
{
    public class TaskController : ApiController
    {
        public IEnumerable<TaskModel> Get()
        {
            return TaskRepository.Instance.GetTasks().OrderBy(x=> x.IsCompleted);
        }

        public void Post([FromBody]TaskModel value)
        {
            value.Id = Guid.NewGuid();
            TaskRepository.Instance.AddTask(value);
        }

        public void Put(Guid id)
        {
            TaskRepository.Instance.CompleteTask(id);
        }
    }
}