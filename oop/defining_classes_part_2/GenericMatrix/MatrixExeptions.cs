namespace GenericMatrix
{
    using System;
    using System.Collections.Generic;
    
    public class MatrixException : SystemException
    {
        public MatrixException() { }
        public MatrixException(string message) : base(message) { }
        public MatrixException(string message, Exception innerException) : base(message, innerException) { }
    }
}
