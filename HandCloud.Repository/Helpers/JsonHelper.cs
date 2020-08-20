using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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

        public List<T> GetData<T>()
        {
            using (StreamReader file = File.OpenText(_path))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                var serializer = new JsonSerializer();
                var data = serializer.Deserialize<IEnumerable<T>>(reader);
                if (data != null)
                    return data.ToList();
                else
                    return null;
            }
        }

        public void SaveData<T>(T data)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.None);
            File.WriteAllText(_path, json);
        }
    }
}
