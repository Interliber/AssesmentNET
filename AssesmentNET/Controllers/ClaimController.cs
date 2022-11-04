using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AssesmentNET.Models;

namespace AssesmentNET.Controllers
{
    public class ClaimController : Controller
    {
        public IList<Claims> claimsList = new List<Claims>
        {new Claims() {Id = 1, Date = "25/05/2022", Description = "This is a claim", Status = "Pending" },
        new Claims() {Id = 1, Date = "25/05/2022", Description = "This is a claim", Status = "Pending" },
        new Claims() {Id = 1, Date = "25/05/2022", Description = "This is a claim", Status = "Pending" },
        new Claims() {Id = 1, Date = "25/05/2022", Description = "This is a claim", Status = "Pending" },
        new Claims() {Id = 1, Date = "25/05/2022", Description = "This is a claim", Status = "Pending" }
        };
        // GET: ClaimController
        public ActionResult Index()
        {
           
            return View(claimsList.OrderBy(c => c.Id).ToList());
        }

        // GET: ClaimController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClaimController/Create
        public ActionResult Create()
        {
            var claimNew = new Claims();
            return View(claimNew);
        }
        public ActionResult CreateClaim(Claims claim)
        {
            claimsList.Add(claim);
            return RedirectToAction(nameof(Index));
        }

        

        // GET: ClaimController/Edit/5
        public ActionResult Edit(int id)
        {
            var cla = claimsList.Where(c => c.Id == id).FirstOrDefault();
            return View(cla);
        }

    }
}
