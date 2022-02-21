using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_15.Entites.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(String message) : base(message)
        {
        }
    }
}
