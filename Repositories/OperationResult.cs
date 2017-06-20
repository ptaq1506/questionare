using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositores
{
    public abstract class OperationResultBase
    {
        public bool HasSucces { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; }

        protected OperationResultBase(bool hasSucces, bool hasError, string message)
        {
            this.HasSucces = hasSucces;
            this.HasError = hasError;
            this.Message = message;
        }

        protected OperationResultBase(Exception ex) : this(false, true, ex.ToString()) { }
    }

    public class OperationResult : OperationResultBase
    {
        public OperationResult(bool hasSucces, bool hasError, string message) : base(hasSucces, hasError, message) { }
    }

    public class OperationMessage
    {
        public OperationMessage()
            : this("")
        { }

        public OperationMessage(string message)
        {
            this.Message = message;
        }

        public string Message { get; set; }
    }

    public class ObjectOperationResult<T> : OperationResultBase
    {
        public T CurrentObject { get; set; }

        public ObjectOperationResult(bool hasSucces, bool hasError, string message)
            : base(hasSucces, hasError, message)
        {
        }

        public ObjectOperationResult(string message, T currentObject)
            : base(true, false, message)
        {
            this.CurrentObject = currentObject;
        }

        public ObjectOperationResult(string message)
            : base(true, false, message)
        {
        }
    }
}
