using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using qcs_product.API.BindingModels;
using qcs_product.API.BusinessProviders;
using qcs_product.API.ViewModels;
using qcs_product.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace qcs_product.API.Controllers
{
    [Route("qcs/v1/[controller]")]
    [ApiController]
    public class PasienController : Controller
    {
        public IActionResult Index()
        {
        return View(Repository.AllPasien);
        }
        //Fungsi Create
        [HttpPost]
        public IActionResult Create(Pasien pasien)
        {
            Repository.Create(pasien);
            return View(pasien);
        }


        //Fungsi Update

        [HttpPost]
        public IActionResult Update(Pasien pasien, string empname)
        {
            Repository.AllPasien.Where(e => e.Name == empname).FirstOrDefault().Id = pasien.Id;
            Repository.AllPasien.Where(e => e.Name == empname).FirstOrDefault().Disease = pasien.Disease;
            Repository.AllPasien.Where(e => e.Name == empname).FirstOrDefault().Nik = pasien.Nik;
            Repository.AllPasien.Where(e => e.Name == empname).FirstOrDefault().Email = pasien.Email;
            Repository.AllPasien.Where(e => e.Name == empname).FirstOrDefault().NoHandphone = pasien.NoHandphone;

            return RedirectToAction("Index");
        }

        //Fungsi Delete
    [HttpPost]
    public IActionResult Delete(string empname)
    {
        var pasienToDelete = Repository.AllPasien.FirstOrDefault(e => e.Name == empname);

        if (pasienToDelete != null)
        {
            Repository.Delete(pasienToDelete);
        }

        return RedirectToAction("Index");
    }

    }
}