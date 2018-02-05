using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test;
using Test.Entities;
using Test.ViewModel;


namespace Test.Controllers
{
    public class RolesController : Controller
    {
        private readonly TestDbContext _context;

        public RolesController(TestDbContext context)
        {
            _context = context;
        }

        // GET: Rols
        public ActionResult Index()
        {
            List<Rol> roles = _context.Roles.ToList();

            List<RolViewModel> rolesToIndex = new List<RolViewModel>();

            foreach (var rol in roles)
            {
                rolesToIndex.Add(Helpers.RolesHelpers.MapRoles(rol));
            }

            return View(rolesToIndex);
        }

        //// GET: Rols/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var rol = await _context.Roles
        //        .SingleOrDefaultAsync(m => m.Id == id);
        //    if (rol == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(rol);
        //}

        //// GET: Rols/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Rols/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Description,Value")] Rol rol)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(rol);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(rol);
        //}

        //// GET: Rols/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var rol = await _context.Roles.SingleOrDefaultAsync(m => m.Id == id);
        //    if (rol == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(rol);
        //}

        //// POST: Rols/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Value")] Rol rol)
        //{
        //    if (id != rol.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(rol);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!RolExists(rol.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(rol);
        //}

        //// GET: Rols/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var rol = await _context.Roles
        //        .SingleOrDefaultAsync(m => m.Id == id);
        //    if (rol == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(rol);
        //}

        //// POST: Rols/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var rol = await _context.Roles.SingleOrDefaultAsync(m => m.Id == id);
        //    _context.Roles.Remove(rol);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool RolExists(int id)
        //{
        //    return _context.Roles.Any(e => e.Id == id);
        //}
    }
}
