using System;

namespace widlife_server.Internal
{
    public class ResponseWrapper<T>
    {
        public T? Data { get; set; }
        public string? Status { get; set; }
        public Boolean Success { get; set; }
    }
}