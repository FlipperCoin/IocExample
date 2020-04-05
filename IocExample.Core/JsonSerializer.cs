using System;

namespace IocExample.Core
{
    public class JsonSerializer : ISerializer
    {
        private IJsonFormat _jsonFormat;

        public JsonSerializer(IJsonFormat jsonFormat)
        {
            _jsonFormat = jsonFormat;
        }

        public string serialize(object obj)
        {
            Console.WriteLine($"Serializing obj with json formatter: {_jsonFormat.GetType()}");
            return "{}";
        }
    }
}