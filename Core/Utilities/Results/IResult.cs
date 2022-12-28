using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // Utilities = Araçlar - Araç
    // Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } // sadece okunabilir
        string Message { get; }
    }
}
