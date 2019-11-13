﻿using System;
using System.Net;
using System.Net.Http;

namespace OsuSharp
{
    public sealed class OsuSharpException : Exception
    {
        public HttpStatusCode StatusCode { get; }

        internal OsuSharpException(string message, HttpStatusCode statusCode) : base(message)
        {
            StatusCode = statusCode;
        }

        internal OsuSharpException(string message, HttpStatusCode statusCode, Exception innerException) : base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }
}
