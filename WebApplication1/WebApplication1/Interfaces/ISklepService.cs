using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Interfaces
{
   public interface ISklepService
    {
        ActionResult<IList<SklepEntity>> GetAll();
        ActionResult<SklepEntity> GetSklepById(int id);
        ActionResult<SklepEntity> SklepSave(SklepEntity sklep);
        ActionResult<SklepEntity> SklepEdit(SklepEntity sklep);
        ActionResult<SklepEntity> SklepDelete(SklepEntity sklep);
    }
}
