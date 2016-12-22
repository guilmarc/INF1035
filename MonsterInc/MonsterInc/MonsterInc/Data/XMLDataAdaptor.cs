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
            var filePath = Constants.UniverseDataPath + typeof(T).Name + ".xml";
            using (var stream = System.IO.File.OpenRead(filePath))
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