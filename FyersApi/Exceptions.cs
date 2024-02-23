using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FyersApi
{
    public class FyersException : Exception
    {
        HttpStatusCode Status;
        public FyersException(string Message, HttpStatusCode HttpStatus, Exception innerException = null) : base(Message, innerException) { Status = HttpStatus; }
    }

    public class GeneralException : FyersException
    {
        public GeneralException(string Message, HttpStatusCode HttpStatus = HttpStatusCode.InternalServerError, Exception innerException = null) : base(Message, HttpStatus, innerException) { }
    }

    public class TokenException : FyersException
    {
        public TokenException(string Message, HttpStatusCode HttpStatus = HttpStatusCode.Forbidden, Exception innerException = null) : base(Message, HttpStatus, innerException) { }
    }


    public class PermissionException : FyersException
    {
        public PermissionException(string Message, HttpStatusCode HttpStatus = HttpStatusCode.Forbidden, Exception innerException = null) : base(Message, HttpStatus, innerException) { }
    }

    public class OrderException : FyersException
    {
        public OrderException(string Message, HttpStatusCode HttpStatus = HttpStatusCode.BadRequest, Exception innerException = null) : base(Message, HttpStatus, innerException) { }
    }

    public class InputException : FyersException
    {
        public InputException(string Message, HttpStatusCode HttpStatus = HttpStatusCode.BadRequest, Exception innerException = null) : base(Message, HttpStatus, innerException) { }
    }

    public class DataException : FyersException
    {
        public DataException(string Message, HttpStatusCode HttpStatus = HttpStatusCode.BadGateway, Exception innerException = null) : base(Message, HttpStatus, innerException) { }
    }

    public class NetworkException : FyersException
    {
        public NetworkException(string Message, HttpStatusCode HttpStatus = HttpStatusCode.ServiceUnavailable, Exception innerException = null) : base(Message, HttpStatus, innerException) { }
    }

}