using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TimerStop.Controllers
{
    public class StopTimerController : ApiController
    {
        
        public string Get()
        {
            return "Timer is finished";
        }

    }
}
