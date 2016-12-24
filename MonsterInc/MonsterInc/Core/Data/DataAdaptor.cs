using System;
using System.Collections.Generic;

namespace Core.Data
{
    /// <summary>
    /// Classe de pont servant à faire le "switch" rapide entre des données codées et XML
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataAdaptor<T> : IDataAdaptor<T>
    {
        public List<T> GetObjects()
        {
            //return new StaticDataAdaptor<T>().GetObjects();
            return new XmlDataAdaptor<T>().GetObjects();
        }
    }
}