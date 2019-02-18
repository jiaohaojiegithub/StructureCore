using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StructureCore.Models;

namespace StructureCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HmBaseFabricsController : Controller
    {
        private readonly erp_baseContext _context;

        public HmBaseFabricsController(erp_baseContext context)
        {
            _context = context;
        }

        // GET: Admin/HmBaseFabrics
        public async Task<IActionResult> Index()
        {
            using (var db = new erp_baseContext())
            {
                return View(await db.HmBaseFabric.ToListAsync());
            }
            //    return View(await _context.HmBaseFabric.ToListAsync());
        }

        // GET: Admin/HmBaseFabrics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hmBaseFabric = await _context.HmBaseFabric
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hmBaseFabric == null)
            {
                return NotFound();
            }

            return View(hmBaseFabric);
        }

        // GET: Admin/HmBaseFabrics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/HmBaseFabrics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BrandId,Brand,FabricCode,FabricName,SupplierCode,Mobile,ValidWidth,ValidWidthUnit,UseWidth,UseWidthUnit,Component,GramWeight,SamplePrice,GoodsPrice,StartQuantity,ArrivalDays,Shrinkage,Pnremark,Picture,Remark,SureDays,ColoringDays,AfterfinishDays,GoodsDays,PrintingDays,CreateDate,CreateUser,ModifyDate,ModifyUser,Status,FabricClass")] HmBaseFabric hmBaseFabric)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hmBaseFabric);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hmBaseFabric);
        }

        // GET: Admin/HmBaseFabrics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hmBaseFabric = await _context.HmBaseFabric.FindAsync(id);
            if (hmBaseFabric == null)
            {
                return NotFound();
            }
            return View(hmBaseFabric);
        }

        // POST: Admin/HmBaseFabrics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BrandId,Brand,FabricCode,FabricName,SupplierCode,Mobile,ValidWidth,ValidWidthUnit,UseWidth,UseWidthUnit,Component,GramWeight,SamplePrice,GoodsPrice,StartQuantity,ArrivalDays,Shrinkage,Pnremark,Picture,Remark,SureDays,ColoringDays,AfterfinishDays,GoodsDays,PrintingDays,CreateDate,CreateUser,ModifyDate,ModifyUser,Status,FabricClass")] HmBaseFabric hmBaseFabric)
        {
            if (id != hmBaseFabric.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hmBaseFabric);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HmBaseFabricExists(hmBaseFabric.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hmBaseFabric);
        }

        // GET: Admin/HmBaseFabrics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hmBaseFabric = await _context.HmBaseFabric
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hmBaseFabric == null)
            {
                return NotFound();
            }

            return View(hmBaseFabric);
        }

        // POST: Admin/HmBaseFabrics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hmBaseFabric = await _context.HmBaseFabric.FindAsync(id);
            _context.HmBaseFabric.Remove(hmBaseFabric);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HmBaseFabricExists(int id)
        {
            return _context.HmBaseFabric.Any(e => e.Id == id);
        }
    }
}
