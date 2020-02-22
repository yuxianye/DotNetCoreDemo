using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpAspNetCoreDemo
{
    public class HomeController : AbpController
    {

        public IActionResult Index()
        {
            return Content("你好 于显野!");
        }
    }
}
