using System;

namespace Core.Exceptions
{
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