using System;
using System.Collections.Generic;
using System.Configuration;
using MyTasks.Web.Models;
using Newtonsoft.Json;
using RestSharp;

namespace MyTasks.Web.Services
{
    public class TaskService
    {
        private string _baseUrl = ConfigurationManager.AppSettings["apiurl"];

        public IEnumerable<TaskModel> GetTasks()
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest("api/Task", Method.GET);

            IRestResponse response = client.Execute(request);

            var result = JsonConvert.DeserializeObject<IEnumerable<TaskModel>>(response.Content);

            return result;
        }


        public void AddTask(string title)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest($"api/Task/", Method.POST)
            {
                RequestFormat = DataFormat.Json
            };

            var model = new TaskModel
            {
                Title = title
            };

            request.AddBody(model);

            client.Execute(request);
        }

        public void CompleteTask(Guid id)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest($"api/Task/{id}", Method.PUT);

            client.Execute(request);
        }


    }
}