using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IFoodData _foodData;
        private readonly IOrderData _orderData;

        public OrdersController(IFoodData foodData,
            IOrderData orderData)
        {
            _foodData = foodData;
            _orderData = orderData;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            var food = await _foodData.GetFood();

            OrderCreate model = new OrderCreate();
            food.ForEach(x =>
            {
                model.FoodItems.Add(new SelectListItem { Value = x.Id.ToString(), Text = x.Title });
            });

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderModel order)
        {
            if(ModelState.IsValid == false)
            {
                return View(order);
            }

            var food = await _foodData.GetFood();
            order.Total = order.Quantity * food.Where(x => x.Id == order.FoodId).First().Price;
            int id = await _orderData.CreateOrder(order);

            return RedirectToAction("Display", new { id });
        }

        public async Task<IActionResult> Display(int id)
        {
            OrderDisplay orderDisplay = new OrderDisplay();
            orderDisplay.Order = await _orderData.GetOrderById(id);

            if(orderDisplay.Order != null)
            {
                var food = await _foodData.GetFood();
                orderDisplay.ItemPurchased = food.Where(x => x.Id == orderDisplay.Order.FoodId).FirstOrDefault()?.Title;
            }

            return View(orderDisplay);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, string orderName)
        {
            await _orderData.UpdateOrderName(id, orderName);
            return RedirectToAction("Display", new { id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            var order = await _orderData.GetOrderById(id);

            return View(order);
        }

        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteById(int id)
        {
            await _orderData.DeleteOrder(id);

            return RedirectToAction("Create");
        }
    }
}
