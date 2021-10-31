using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3FinalProject.Models;
using Module3FinalProject.Services.Abstractions;

namespace Module3FinalProject
{
    public class Application
    {
        private readonly IFileProcessor _fileProcessor;
        private readonly IDataProcessor _dataProcessor;

        public Application(IFileProcessor fileProcessor, IDataProcessor dataProcessor)
        {
            _fileProcessor = fileProcessor;
            _dataProcessor = dataProcessor;
        }

        public async Task RunAsync()
        {
            var users = await _fileProcessor.ReadUserCollectionAsync("users.txt");
            var orders = await _fileProcessor.ReadOrderCollectionAsync("orders.txt");

            var result = _dataProcessor.JoinUsersToOrders(users, orders);

            await _fileProcessor.WriteCollectionAsync("result.txt", result);
        }
    }
}
