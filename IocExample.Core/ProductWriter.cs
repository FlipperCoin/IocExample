using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IocExample.Core
{
    public class ProductWriter : IProductWriter
    {
        private readonly ISerializer _serializer;
        private readonly Stream _stream;

        public ProductWriter(ISerializer serializer, Stream stream)
        {
            _serializer = serializer;
            _stream = stream;
        }

        public void Write(Product product)
        {
            string serializedProduct = _serializer.serialize(product);
            using (var streamWriter = new StreamWriter(_stream))
            {
                streamWriter.Write(serializedProduct);
            }
        }
    }
}
