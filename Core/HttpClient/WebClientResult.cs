using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Core.HttpClient
{
    public class WebClientResult<T>
    {
        public WebClientResult()
        {
            hasErrors = false;
        }
        public T Result { get; set; }
        public string Error { get; set; }
        public bool hasErrors { get; set; }
   
    }
}
