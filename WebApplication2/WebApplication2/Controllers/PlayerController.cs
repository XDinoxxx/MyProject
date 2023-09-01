using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PlayerController : Controller
    {

        private readonly PlayerDbContext _context;

        public PlayerController(PlayerDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Players.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Player player = new Player { Id = id.Value };
                _context.Entry(player).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index"); 
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id != null)
            {
                Player? player = await _context.Players.FirstOrDefaultAsync(x => x.Id == id);
                if(player != null) return View(player);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Player player)
        {
            _context.Players.Update(player);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
