using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Response : IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
}
