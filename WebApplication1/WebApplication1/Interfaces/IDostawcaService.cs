using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Interfaces
{
   public interface IDostawcaService
    {
        ActionResult<IList<DostawcaEntity>> GetAll();
        ActionResult<DostawcaEntity> GetDostawcaById(int id);
        ActionResult<DostawcaEntity> DostawcaSave(DostawcaEntity dostawca);
        ActionResult<DostawcaEntity> DostawcaEdit(DostawcaEntity dostawca);
        ActionResult<DostawcaEntity> DostawcaDelete(DostawcaEntity dostawca);
    }
}
