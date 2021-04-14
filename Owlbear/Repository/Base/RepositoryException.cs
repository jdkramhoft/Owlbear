using System;

namespace Owlbear.Repository.Base
{
    public class RepositoryException : Exception
    {
        public RepositoryException(string msg) : base(msg)
        {
            
        }
    }
}