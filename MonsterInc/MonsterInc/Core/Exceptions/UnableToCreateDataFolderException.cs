using System;

namespace Core.Exceptions
{
    /// <summary>
    /// Lancée lorsque la création automatique des répertoires systèmes échoue
    /// </summary>
    public class UnableToCreateDataFolderException : Exception
    {
        public UnableToCreateDataFolderException()
        {
        }

        public UnableToCreateDataFolderException(string folder) : base( $@"Impossible de créer le répertoire {folder}'.")
        {
           
        }
    }
}