using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePractice1.Handler
{
    public interface IErrorHandlingService<T>
    {
        void SetError(T error);
        T GetError();
    }
   
}
