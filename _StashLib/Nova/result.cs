using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace _StashLib.Nova
{
    public class Result<T>
    {
        public T Data { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
