using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Module3FinalProject.Services;
using Module3FinalProject.Models;

namespace Module3FinalProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var starter = new Starter();
            await starter.StartApplicationAsync();
        }
    }
}
