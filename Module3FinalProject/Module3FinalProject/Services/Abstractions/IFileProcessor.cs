using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3FinalProject.Models;

namespace Module3FinalProject.Services.Abstractions
{
    public interface IFileProcessor
    {
        public Task<IEnumerable<User>> ReadUserCollectionAsync(string path);
        public Task<IEnumerable<Order>> ReadOrderCollectionAsync(string path);
        public Task WriteCollectionAsync(string path, IEnumerable collection);
    }
}
