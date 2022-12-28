using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        // Örnek 1
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        // Örnek 2
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        // Örnek 3 (Az Kullanılan)
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        // Örnek 4 (Az Kullanılan)
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
