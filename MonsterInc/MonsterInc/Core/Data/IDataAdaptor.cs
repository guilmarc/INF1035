using System.Collections.Generic;

namespace Core.Data
{
    /// <summary>
    /// Interface définissant le contrat des adaptateur de données
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataAdaptor<T>
    {
        List<T> GetObjects();
    }
}