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
    public class TowarService : ITowarSerivce
    {
        private ApkaContext _context;
        public TowarService(ApkaContext context)
        {
            _context = context;
        }

        ActionResult<IList<TowarEntity>> ITowarSerivce.GetAll()
        {
            return _context.Towary.ToList();
        }

        public ActionResult<TowarEntity> GetTowarId(int id)
        {
           return _context.Towary.FirstOrDefault(towar => towar.id == id);
        }

        public ActionResult<TowarEntity> TowarDelete(TowarEntity towar)
        {
            _context.Towary.Remove(towar);
            var wynikZapisu = _context.SaveChanges();

            if (wynikZapisu > 0)
            {
                return new OkResult();
            }
            return new BadRequestResult();
        }

        public ActionResult<TowarEntity> TowarEdit(TowarEntity towar)
        {
            _context.Towary.Update(towar);
            var zapisWyniku = _context.SaveChanges();
            if (zapisWyniku > 0)
            {
                return new OkResult();
            }
            return new BadRequestResult();
        }

        public ActionResult<TowarEntity> TowarSave(TowarEntity towar)
        {
            _context.Towary.Add(towar);
            var zapisWyniku = _context.SaveChanges();
            if (zapisWyniku > 0)
            {
                return new OkResult();
            }
            return new BadRequestResult();
        }


    }
}
