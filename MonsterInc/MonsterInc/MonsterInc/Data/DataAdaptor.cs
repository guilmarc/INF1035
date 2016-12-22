using System;
using System.Collections.Generic;

namespace Core.Data
{
    public class DataAdaptor<T> : IDataAdaptor<T>
    {
        public List<T> GetObjects()
        {
            //return new HardCodedDataAdaptor<T>().GetObjects();
            return new XMLDataAdaptor<T>().GetObjects();
        }
    }
}