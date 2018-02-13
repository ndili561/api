using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

using System.Net.Http;
using System.Net;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ResponseController : Controller
    {
        private readonly IMapper map;
        //private readonly BaseDal context;

        //public ResponseController(IMapper mapper,BaseDal dal)
        //{


        //    map = mapper;
        //    context = dal;
        //}

        [HttpGet]
        [Route("api/response")]
        public IActionResult Index()
        {
        
            return View();
        }

        //public HttpResponseMessage response()
        //{
        //    //var res = new HttpResponseMessage();
        //    //var re = new ResponseDTO();
        //    //re.name = "myname";
        //    //var r = map.Map<Response>(re);
        //    //context.Add(r);
        //    //context.SaveChanges();
        //    //return res;

        //}
    }
}