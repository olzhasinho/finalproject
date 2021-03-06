﻿using ArtShop3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace ArtShop3.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly Service service;
        private readonly AppDbContext _context;
        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart, AppDbContext context, Service service)
        {
            _orderRepository = orderRepository;
            _context = context;
            _shoppingCart = shoppingCart;
            this.service = service;
        }


        // GET: /<controller>/
        public IActionResult Checkout() 
        {
            return View();
        }
        public IActionResult SendEmailDefault()
        {
            service.SendEmailDefault();
            return RedirectToAction("CheckoutComplete");
        }
        public IActionResult SendEmailCustom()
        {
            service.SendEmailCustom();
            return RedirectToAction("CheckoutComplete");
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some arts first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }


        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "thank you";

            return View();
        }


    }
}
