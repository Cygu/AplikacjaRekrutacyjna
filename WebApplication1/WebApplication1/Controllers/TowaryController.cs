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

    public class TowaryController : ControllerBase
    {
        private ITowarSerivce _towarSerivce;

        public TowaryController(ITowarSerivce towarSerivce)
        {
            _towarSerivce = towarSerivce;

        }
        [HttpGet("getAll")]
        public ActionResult<IList<TowarEntity>> GetAll()
        {
            return _towarSerivce.GetAll();
        }
    
        [HttpGet("getTowarById/{id}")]
        public ActionResult<TowarEntity> GetTowarById(int id)
        {
            return _towarSerivce.GetTowarId(id);
        }

        [HttpPost("saveTowar")]
        public ActionResult<TowarEntity> SaveTowar([FromBody] TowarEntity towar)
        {
            return _towarSerivce.TowarSave(towar);
        }



        [HttpPut("editTowar")]
        public ActionResult<TowarEntity> EditTowar([FromBody] TowarEntity towar)
        {
            return _towarSerivce.TowarEdit(towar);
        }

        [HttpDelete("deleteTowar")]
        public ActionResult<TowarEntity> DeleteTowar([FromBody] TowarEntity towar)
        {
            return _towarSerivce.TowarDelete(towar);
        }

    }
}
