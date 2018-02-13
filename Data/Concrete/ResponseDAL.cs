using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Data.Abstract;



namespace Data.Concrete
{
    public class ResponseDAL : EntityRepositoryBase<Response, BaseDal>, IResponseDAL
    {
    }
}
