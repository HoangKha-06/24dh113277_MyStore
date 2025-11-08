using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24dh113277_MyStore.Models.ViewModel
{
    public class CartService : Controller
    {
        private readonly HttpSessionStateBase sesstion;

        public CartService(HttpSessionStateBase sesstion)
        {
            this.sesstion = sesstion;
        }

        public Cart GetCart()
        {
            var cart = (Cart)sesstion["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                sesstion["Cart"] = cart;
            }
            return cart;
        }

        public void ClearCart()
        {
            sesstion["Cart"] = null;
        }
    }
}