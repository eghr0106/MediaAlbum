using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.HttpClient
{
    public interface IWebClient
    {
        Task<T> GetContent<T>(string endPoint);
    }
}
