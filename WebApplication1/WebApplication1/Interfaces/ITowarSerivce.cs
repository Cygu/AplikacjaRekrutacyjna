using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Interfaces
{
   public interface ITowarSerivce
    {
        ActionResult<IList<TowarEntity>> GetAll();
        ActionResult<TowarEntity> GetTowarId(int id);
        ActionResult<TowarEntity> TowarSave(TowarEntity towar);
        ActionResult<TowarEntity> TowarEdit(TowarEntity towar);
        ActionResult<TowarEntity> TowarDelete(TowarEntity towar);
    }
}
