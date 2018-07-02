using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Interfaces;
using WebApplication1.Model;

namespace WebApplication1.Services
{
    public class DostawcaService : IDostawcaService
    {
        private ApkaContext _context;

        public DostawcaService(ApkaContext context)
        {
             _context = context;
        }

        public ActionResult<IList<DostawcaEntity>> GetAll()
        {
          
            return _context.Dostawcy.ToList();
        }

        public ActionResult<DostawcaEntity> GetDostawcaById(int id)
        {

            return _context.Dostawcy.FirstOrDefault(dostawca => dostawca.id == id);
            
        }

        public ActionResult<DostawcaEntity> DostawcaSave(DostawcaEntity nowyDostawca)
        {
            _context.Dostawcy.Add(nowyDostawca);
            var wynikZapisu = _context.SaveChanges();

            if (wynikZapisu > 0)
            {
                return new OkResult();
            }
            return new BadRequestResult();
        }

        public ActionResult<DostawcaEntity> DostawcaEdit(DostawcaEntity dostawca)
        {
            _context.Dostawcy.Update(dostawca);
            var wynikZapisu = _context.SaveChanges();

            if (wynikZapisu > 0)
            {
                return new OkResult();
            }
            return new BadRequestResult();
        }

        public ActionResult<DostawcaEntity> DostawcaDelete(DostawcaEntity dostawca)
        {
            _context.Dostawcy.Remove(dostawca);
            var wynikZapisu = _context.SaveChanges();

            if (wynikZapisu > 0)
            {
                return new OkResult();
            }
            return new BadRequestResult();
        }

    }
}
