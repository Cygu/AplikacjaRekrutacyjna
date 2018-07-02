using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Interfaces;
using WebApplication1.Model;

namespace WebApplication1.Services
{
    public class SklepService : ISklepService
    {
        private ApkaContext _context;
        public SklepService(ApkaContext context)
        {
            _context = context;
        }

        ActionResult<IList<SklepEntity>> ISklepService.GetAll()
        {
            return _context.Sklepy.ToList();
        }

        public ActionResult<SklepEntity> GetSklepById(int id)
        {
            return _context.Sklepy.FirstOrDefault(dostawca => dostawca.id == id);
        }

        public ActionResult<SklepEntity> SklepDelete(SklepEntity sklep)
        {
            _context.Sklepy.Remove(sklep);
            var zapisWyniku = _context.SaveChanges();
            if (zapisWyniku > 0)
            {
                return new OkResult();
            }
            return new BadRequestResult();
        }

        public ActionResult<SklepEntity> SklepEdit(SklepEntity sklep)
        {
            _context.Sklepy.Update(sklep);
            var zapisWyniku = _context.SaveChanges();
            if (zapisWyniku > 0)
            {
                return new OkResult();
            }
            return new BadRequestResult();
        }

        public ActionResult<SklepEntity> SklepSave(SklepEntity sklep)
        {
            _context.Sklepy.Add(sklep);
            var zapisWyniku = _context.SaveChanges();
            if (zapisWyniku > 0)
            {
                return new OkResult();
            }
            return new BadRequestResult();
        }

       

 

    }
}
