using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SklepyController : ControllerBase
    {
        private ISklepService _SklepService;

        public SklepyController(ISklepService sklepService)
        {
            _SklepService = sklepService;
        }

        [HttpGet("getAll")]
        public ActionResult<IList<SklepEntity>> GetAll()
        {
            return _SklepService.GetAll();
        }

        [HttpGet("getSklepById/{id}")]
        public ActionResult<SklepEntity> GetSklepById(int id)
        {
            return _SklepService.GetSklepById(id);
        }

        [HttpPost("saveSklep")]
        public ActionResult<SklepEntity> SaveSklep([FromBody] SklepEntity sklep)
        {
            return _SklepService.SklepSave(sklep);
         }

        [HttpPut("editSklep")]
        public ActionResult<SklepEntity> EditSklep([FromBody] SklepEntity sklep)
        {
            return _SklepService.SklepEdit(sklep);
                }

        [HttpDelete("deleteSklep")]
        public ActionResult<SklepEntity> DeleteSklep([FromBody] SklepEntity sklep)
        {
            return _SklepService.SklepDelete(sklep);
        }
    }
}
