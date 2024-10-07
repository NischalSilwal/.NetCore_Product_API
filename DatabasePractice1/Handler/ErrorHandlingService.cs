using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePractice1.Handler
{
    public class ErrorHandlingService<T> : IErrorHandlingService<T>
    {
        private T _error;
        public void SetError(T error)
        {
            _error = error;
        }
        public T GetError() => _error;
    }
}
