using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class ExceptionExtention
    {
        public static IEnumerable<Exception> EnumarateExceptions(this Exception e)
        {
            while(e != null)
            {
                yield return e;

                e = e.InnerException;
            }
        }
    }
}
