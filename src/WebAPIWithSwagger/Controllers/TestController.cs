using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIWithSwagger.Controllers
{
    /// <summary>
    /// 这个是测试控制器
    /// </summary>
    [ApiController]
    [Route("[controller]",Name = "测试控制器", Order =1)]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 这个是获取Test接口
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Get()
        {
            return "This is a test!";
        }

        /// <summary>
        /// 这个是另一个获取Test接口
        /// </summary>
        /// <param name="name">参数名称</param>
        /// <returns></returns>
        [HttpGet]
        public string ShowByName(string name)
        {
            return $"This is a {name}!";
        }

        /// <summary>
        /// 这个是POSt接口
        /// </summary>
        /// <param name="name">参数名称</param>
        /// <returns></returns>
        [HttpPost]
        public string Hello(string name)
        {
            return $"This is a {name}!";
        }
    }
}
