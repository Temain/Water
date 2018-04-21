using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Water.Domain.DataAccess.Interfaces;

namespace Water.Web.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        public HomeController(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
