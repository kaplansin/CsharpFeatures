using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Domain
{
    public struct GenericResponse<T>
    {
        private readonly bool _success;
        private readonly T _result;
        private readonly Exception _exception;
        public GenericResponse(bool success, T result, Exception ex=null)
        {
            this._success = success;
            this._result = result;
            this._exception = ex;
        }
        public bool IsSuccess()
        {
            return _success;
        }
        public T GetResult()
        {
            return _result;
        }
    }


}
