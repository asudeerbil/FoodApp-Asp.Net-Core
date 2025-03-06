using FinalProje.Data;
using FinalProje.Dto;
using FinalProje.Models;
using FinalProje.Oturum;
using Microsoft.AspNetCore.Mvc;

namespace FinalProje.Component
{
    public class CartSumList : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public CartSumList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();

            CartViewModel cartVm = new()
            {
                CartItems = cart,
                GrandTotal = cart.Sum(x => x.Quantity * x.Price)
            };
            return View(cartVm);
        }

    }
}
