using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public interface ISayHello
    {
        string Talk();
    }

    public class SayHello : ISayHello
    {
        public string Talk()
        {
            return "Hello from SayHello";
        }
    }
}