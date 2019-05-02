using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics.Domain
{
    public static class Helper
    {
        public static GenericResponse<IEnumerable<T>> GetDistinct<T>(this IEnumerable<T> left)
        {
            try
            {
                IEnumerable<T> distinct = left.Distinct();
                bool success = distinct.Count() > 0 ;
                return  new GenericResponse<IEnumerable<T>>(success, distinct,null);
            }
            catch(Exception ex)
            {
                return new GenericResponse<IEnumerable<T>>(false, null, ex);
            }
            
        }
    }
}
