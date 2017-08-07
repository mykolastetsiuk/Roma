using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SEOCRMTest.Data;
using SEOCRMTest.Models.WorkSpaceModels;

namespace SEOCRMTest.Controllers
{
    public class DomainsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DomainsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Domains
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Domain.Include(d => d.DomainAdminPanel).Include(d => d.Owner).Include(d => d.Project).Include(d => d.Registrar).Include(d => d.Server).Include(d => d.StatusDomain).Include(d => d.TypeDomain);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Domains/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domain = await _context.Domain
                .Include(d => d.DomainAdminPanel)
                .Include(d => d.Owner)
                .Include(d => d.Project)
                .Include(d => d.Registrar)
                .Include(d => d.Server)
                .Include(d => d.StatusDomain)
                .Include(d => d.TypeDomain)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (domain == null)
            {
                return NotFound();
            }

            return View(domain);
        }

        // GET: Domains/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(_context.DomainAdminPanel, "Id", "Id");
            ViewData["OwnerId"] = new SelectList(_context.Owner, "Id", "Id");
            ViewData["ProjectId"] = new SelectList(_context.Project, "Id", "Id");
            ViewData["RegistrarId"] = new SelectList(_context.Registrar, "Id", "Id");
            ViewData["ServerId"] = new SelectList(_context.Server, "Id", "Id");
            ViewData["StatusDomainId"] = new SelectList(_context.StatusDomain, "Id", "Id");
            ViewData["TypeDomainId"] = new SelectList(_context.TypeDomain, "Id", "Id");
            return View();
        }

        // POST: Domains/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,MainDomain,IP,ExpiredDate,ServerId,RegistrarId,ProjectId,OwnerId,TypeDomainId,Redirect,StatusDomainId,DomainAdminPanelId,AdditionalInfo")] Domain domain)
        {
            if (ModelState.IsValid)
            {
                _context.Add(domain);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["Id"] = new SelectList(_context.DomainAdminPanel, "Id", "Id", domain.Id);
            ViewData["OwnerId"] = new SelectList(_context.Owner, "Id", "Id", domain.OwnerId);
            ViewData["ProjectId"] = new SelectList(_context.Project, "Id", "Id", domain.ProjectId);
            ViewData["RegistrarId"] = new SelectList(_context.Registrar, "Id", "Id", domain.RegistrarId);
            ViewData["ServerId"] = new SelectList(_context.Server, "Id", "Id", domain.ServerId);
            ViewData["StatusDomainId"] = new SelectList(_context.StatusDomain, "Id", "Id", domain.StatusDomainId);
            ViewData["TypeDomainId"] = new SelectList(_context.TypeDomain, "Id", "Id", domain.TypeDomainId);
            return View(domain);
        }

        // GET: Domains/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domain = await _context.Domain.SingleOrDefaultAsync(m => m.Id == id);
            if (domain == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.DomainAdminPanel, "Id", "Id", domain.Id);
            ViewData["OwnerId"] = new SelectList(_context.Owner, "Id", "Id", domain.OwnerId);
            ViewData["ProjectId"] = new SelectList(_context.Project, "Id", "Id", domain.ProjectId);
            ViewData["RegistrarId"] = new SelectList(_context.Registrar, "Id", "Id", domain.RegistrarId);
            ViewData["ServerId"] = new SelectList(_context.Server, "Id", "Id", domain.ServerId);
            ViewData["StatusDomainId"] = new SelectList(_context.StatusDomain, "Id", "Id", domain.StatusDomainId);
            ViewData["TypeDomainId"] = new SelectList(_context.TypeDomain, "Id", "Id", domain.TypeDomainId);
            return View(domain);
        }

        // POST: Domains/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,MainDomain,IP,ExpiredDate,ServerId,RegistrarId,ProjectId,OwnerId,TypeDomainId,Redirect,StatusDomainId,DomainAdminPanelId,AdditionalInfo")] Domain domain)
        {
            if (id != domain.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(domain);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DomainExists(domain.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["Id"] = new SelectList(_context.DomainAdminPanel, "Id", "Id", domain.Id);
            ViewData["OwnerId"] = new SelectList(_context.Owner, "Id", "Id", domain.OwnerId);
            ViewData["ProjectId"] = new SelectList(_context.Project, "Id", "Id", domain.ProjectId);
            ViewData["RegistrarId"] = new SelectList(_context.Registrar, "Id", "Id", domain.RegistrarId);
            ViewData["ServerId"] = new SelectList(_context.Server, "Id", "Id", domain.ServerId);
            ViewData["StatusDomainId"] = new SelectList(_context.StatusDomain, "Id", "Id", domain.StatusDomainId);
            ViewData["TypeDomainId"] = new SelectList(_context.TypeDomain, "Id", "Id", domain.TypeDomainId);
            return View(domain);
        }

        // GET: Domains/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domain = await _context.Domain
                .Include(d => d.DomainAdminPanel)
                .Include(d => d.Owner)
                .Include(d => d.Project)
                .Include(d => d.Registrar)
                .Include(d => d.Server)
                .Include(d => d.StatusDomain)
                .Include(d => d.TypeDomain)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (domain == null)
            {
                return NotFound();
            }

            return View(domain);
        }

        // POST: Domains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var domain = await _context.Domain.SingleOrDefaultAsync(m => m.Id == id);
            _context.Domain.Remove(domain);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool DomainExists(int id)
        {
            return _context.Domain.Any(e => e.Id == id);
        }
    }
}
