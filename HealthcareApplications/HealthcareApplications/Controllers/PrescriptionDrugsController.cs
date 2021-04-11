using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthcareApplications.Data;
using HealthcareApplications.Models;

namespace HealthcareApplications.Controllers
{
    public class PrescriptionDrugsController : Controller
    {
        private readonly PrescriptionDrugContext _context;

        public PrescriptionDrugsController(PrescriptionDrugContext context)
        {
            _context = context;
        }

        // GET: PrescriptionDrugs
        public async Task<IActionResult> Index()
        {
            return View(await _context.PrescriptionDrugs.ToListAsync());
        }

        // GET: PrescriptionDrugs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prescriptionDrug = await _context.PrescriptionDrugs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prescriptionDrug == null)
            {
                return NotFound();
            }

            return View(prescriptionDrug);
        }

        // GET: PrescriptionDrugs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PrescriptionDrugs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PrescriptionId,DrugId,Quantity,Dosage,RefillCount")] PrescriptionDrug prescriptionDrug)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prescriptionDrug);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prescriptionDrug);
        }

        // GET: PrescriptionDrugs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prescriptionDrug = await _context.PrescriptionDrugs.FindAsync(id);
            if (prescriptionDrug == null)
            {
                return NotFound();
            }
            return View(prescriptionDrug);
        }

        // POST: PrescriptionDrugs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PrescriptionId,DrugId,Quantity,Dosage,RefillCount")] PrescriptionDrug prescriptionDrug)
        {
            if (id != prescriptionDrug.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prescriptionDrug);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrescriptionDrugExists(prescriptionDrug.Id))
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
            return View(prescriptionDrug);
        }

        // GET: PrescriptionDrugs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prescriptionDrug = await _context.PrescriptionDrugs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prescriptionDrug == null)
            {
                return NotFound();
            }

            return View(prescriptionDrug);
        }

        // POST: PrescriptionDrugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prescriptionDrug = await _context.PrescriptionDrugs.FindAsync(id);
            _context.PrescriptionDrugs.Remove(prescriptionDrug);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrescriptionDrugExists(int id)
        {
            return _context.PrescriptionDrugs.Any(e => e.Id == id);
        }
    }
}
