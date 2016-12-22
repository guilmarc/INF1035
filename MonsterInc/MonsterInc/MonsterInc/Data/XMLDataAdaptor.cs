using System;
using System.Collections.Generic;
using Core.Model;
using System.Xml.Serialization;

namespace Core.Data
{
    public class XMLDataAdaptor<T> : IDataAdaptor<T>
    {
        public List<T> GetObjects()
        {
            using (var stream = System.IO.File.OpenRead("C:/xml/" + typeof(T).Name + ".xml"))
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                return serializer.Deserialize(stream) as List<T>;
            }
        }

        public void SetObjects<TObjects>(TObjects objects)
        {
            //Non utilisé
        }
    }
}