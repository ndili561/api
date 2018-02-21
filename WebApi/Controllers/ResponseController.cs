using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Data.Concrete;
using System.Net.Http;
using System.Net;
using Entities.DTO;
using Entities.Concrete;
using Services.Concrete;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ResponseController : Controller
    {
        private readonly IMapper map;
        private readonly BaseDal context;
        private readonly ResponseService rest;

        public ResponseController(IMapper mapper, BaseDal dal, ResponseService r)
        {

            
            map = mapper;
            context = dal;
        }

        [HttpGet]
        [Route("api/response")]
        public IActionResult Index()
        {
        
            return View();
        }

        public HttpResponseMessage response(Response rs)
        {

            rest.add();
            var res = new HttpResponseMessage();
            context.Add(rs);
            //var re = new ResponseDTO();
            //re.name = "myname";
            var r = map.Map<Response>(rs);
            //context.Add(r);
            //context.SaveChanges();
            return res;

        }
    }
}