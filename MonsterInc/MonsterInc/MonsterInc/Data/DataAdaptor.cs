using System;
using System.Collections.Generic;

namespace Core.Data
{
    public class DataAdaptor<T> : IDataAdaptor<T>
    {
        public List<T> getObjects()
        {
            return new HardCodedDataAdaptor<T>().getObjects();
        }
    }
}