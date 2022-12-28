using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        // Örnek 1
        public SuccessDataResult(T data, string message):base(data,true,message)
        {

        }
        // Örnek 2
        public SuccessDataResult(T data):base(data,true)
        {

        }
        // Örnek 3 (Az Kullanılan)
        public SuccessDataResult(string message):base(default,true,message)
        {

        }
        // Örnek 4 (Az Kullanılan)
        public SuccessDataResult():base(default,true)   
        {

        }
    }
}
