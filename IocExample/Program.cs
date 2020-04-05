using System.IO;
using IocExample.Core;

namespace IocExample
{
    class Program
    {
        static void Main(string[] args)
        {
            InitComponents();
        }

        private static void InitComponents()
        {
            var jsonFormat = new RawJsonFormat();

            var serializer = new JsonSerializer(jsonFormat);
            var stream = new MemoryStream();

            var productWriter = new ProductWriter(serializer, stream);
        }
    }
}
