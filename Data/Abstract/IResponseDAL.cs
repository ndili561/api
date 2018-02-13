using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace Data.Abstract
{
    public interface IResponseDAL : IEntityRepository<Response>
    {
    }
}
