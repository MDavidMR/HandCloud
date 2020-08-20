using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HandCloud.Repository.Helpers
{
    public class JsonHelper : IJsonHelper
    {
        private string _path = AppContext.BaseDirectory + "data.json";

        public JsonHelper()
        {
            if (!File.Exists(_path))
            {
                var stream = File.Create(_path);
                stream.Close();
            }
        }

        public async Task<List<T>> GetData<T>()
        {
            IEnumerable<T> data = null;
            string json;
            using (StreamReader file = File.OpenText(_path))
            {
                json = await file.ReadToEndAsync();
                data = JsonConvert.DeserializeObject<IEnumerable<T>>(json);
            }

            if (data != null)
                return data.ToList();
            else
                return null;

        }


        public async Task SaveData<T>(T data)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.None);
            await File.WriteAllTextAsync(_path, json);

        }
    }
}
