using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WodzitsuSite.Data.Repositories;

namespace WodzitsuSite.Controllers
{
    public class CzlopolController : Controller
    {
        private readonly ITourRepository repo;

        public CzlopolController(ITourRepository repo)
        {
            this.repo = repo;
        }

    }
}
