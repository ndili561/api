using System;
using Core.Entities;

namespace Container
{
    public class Response : IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
}
