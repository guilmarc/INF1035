using System;
using System.Collections.Generic;
using Core.Model;
using System.Xml.Serialization;

namespace Core.Data
{
    /// <summary>
    /// Implémantation d'un adapteur de données lié à des fichiers Xml
    /// </summary>
    /// <typeparam name="T">Type de liste à obtenir</typeparam>
    public class XmlDataAdaptor<T> : IDataAdaptor<T>
    {
        /// <summary>
        /// Retourne une liste typés d'objet selon le type demandé
        /// </summary>
        /// <returns></returns>
        public List<T> GetObjects()
        {
            var filePath = Constants.UniverseDataPath + typeof(T).Name + ".xml";
            using (var stream = System.IO.File.OpenRead(filePath))
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                return serializer.Deserialize(stream) as List<T>;
            }
        }
    }
}