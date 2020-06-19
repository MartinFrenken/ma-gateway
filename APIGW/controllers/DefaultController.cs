using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIGW.controllers
{
    [Route("/")]
    public class IndexController : Controller
    {
        // Used to give healthy status back to ingress
        public String Index()
        {
            return "healthy";
        }
    }
}