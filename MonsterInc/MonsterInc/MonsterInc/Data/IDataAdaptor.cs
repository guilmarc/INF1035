using System.Collections.Generic;

namespace Core.Data
{
    public interface IDataAdaptor<T>
    {
        List<T> getObjects();
    }
}