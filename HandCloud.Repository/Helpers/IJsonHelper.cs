using System;
using System.Collections.Generic;
using System.Text;

namespace HandCloud.Repository.Helpers
{
    public interface IJsonHelper
    {
        List<T> GetData<T>();

        void SaveData<T>(T data);
    }
}
