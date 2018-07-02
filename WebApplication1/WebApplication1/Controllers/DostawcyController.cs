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

    public class DostawcyController : ControllerBase
    {
        private IDostawcaService _dostawcaService;

        public DostawcyController(IDostawcaService dostawcaService)
        {
            _dostawcaService = dostawcaService;

        }
        [HttpGet("getAll")]
        public ActionResult<IList<DostawcaEntity>> GetAll()
        {
            return _dostawcaService.GetAll();
        }

        [HttpGet("getDostawcaById/{id}")]
        public ActionResult<DostawcaEntity> GetDostawcaById(int id)
        {
            return _dostawcaService.GetDostawcaById(id);
        }

        [HttpPost("saveDostawca")]
        public ActionResult<DostawcaEntity> SaveDostawca([FromBody] DostawcaEntity dostawca)
        {
            return _dostawcaService.DostawcaSave(dostawca);
        }

        [HttpPut("editDostawca")]
        public ActionResult<DostawcaEntity> EditDostawca([FromBody] DostawcaEntity dostawca)
        {
            return _dostawcaService.DostawcaEdit(dostawca);
        }

        [HttpDelete("deleteDostawca")]
        public ActionResult<DostawcaEntity> DeleteDostawca([FromBody] DostawcaEntity dostawca)
        {
            return _dostawcaService.DostawcaDelete(dostawca);
        }

    }
}
