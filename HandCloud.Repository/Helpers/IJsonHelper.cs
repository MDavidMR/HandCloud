using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HandCloud.Repository.Helpers
{
    public interface IJsonHelper
    {
        Task<List<T>> GetData<T>();

        Task SaveData<T>(T data);
    }
}