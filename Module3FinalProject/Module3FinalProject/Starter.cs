using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Module3FinalProject.Services;
using Module3FinalProject.Services.Abstractions;

namespace Module3FinalProject
{
    public class Starter
    {
        public async Task StartApplicationAsync()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IDataProcessor, DataProcessor>()
                .AddTransient<IFileProcessor, FileProcessor>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            var application = serviceProvider.GetService<Application>();
            await application.RunAsync();
        }
    }
}
