using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Core_Web_App_MVC_.Data;
using ASP.NET_Core_Web_App_MVC_.Models;

namespace ASP.NET_Core_Web_App_MVC_.Controllers
{
    public class BetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bets
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Bet.Include(b => b.Customer).Include(b => b.Product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Bets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bet = await _context.Bet
                .Include(b => b.Customer)
                .Include(b => b.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bet == null)
            {
                return NotFound();
            }

            return View(bet);
        }

        // GET: Bets/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            return View();
        }

        // POST: Bets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Time,StartPrice,CustomerId,ProductId")] Bet bet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", bet.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", bet.ProductId);
            return View(bet);
        }

        // GET: Bets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bet = await _context.Bet.FindAsync(id);
            if (bet == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", bet.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", bet.ProductId);
            return View(bet);
        }

        // POST: Bets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Time,StartPrice,CustomerId,ProductId")] Bet bet)
        {
            if (id != bet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BetExists(bet.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", bet.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", bet.ProductId);
            return View(bet);
        }

        // GET: Bets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bet = await _context.Bet
                .Include(b => b.Customer)
                .Include(b => b.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bet == null)
            {
                return NotFound();
            }

            return View(bet);
        }

        // POST: Bets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bet = await _context.Bet.FindAsync(id);
            _context.Bet.Remove(bet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BetExists(int id)
        {
            return _context.Bet.Any(e => e.Id == id);
        }
    }
}
