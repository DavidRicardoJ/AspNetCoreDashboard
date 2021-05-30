using AspNetCoreDashboard.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDashboard.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult ChartSerie()
        {
            HighChartsSeries series = new ();
            return Json(series.GetDataChart());
        }
    }
}
