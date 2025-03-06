using FinalProje.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProje.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult List()
        {
            var order = _context.Orders
                                .Include(o => o.User)
                                .Include(o => o.OrderItems)
                                .ThenInclude(oi => oi.Product)
                                .ToList();

            if (order == null)
            {
                return NotFound();
            }

           

            return View(order);
        }
        public IActionResult Details(int id)
        {
            var order = _context.Orders
                                .Include(o => o.User)
                                .Include(o => o.OrderItems)
                                .ThenInclude(oi => oi.Product)
                                .FirstOrDefault(o => o.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
    }
}
