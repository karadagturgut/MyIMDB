using CoreApplication.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreApplication.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString() == "Index")
                ViewBag.SecilenKategori = RouteData?.Values["id"]; 
            return View(Data.CategoryRepository.Categories);
        }
    }
}
