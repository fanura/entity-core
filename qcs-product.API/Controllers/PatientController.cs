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
        Pasien pasien = Repository.AllPasien.Where(e => e.Name == empname).FistOrDefault();
        return View(Repository.AllPasien);
        }
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
         Repository.AllEmpoyees.Where(e => e.Name == empname).FirstOrDefault().Id = employee.Id;
         Repository.AllEmpoyees.Where(e => e.Name == empname).FirstOrDefault().Disease = employee.Disease;
         Repository.AllEmpoyees.Where(e => e.Name == empname).FirstOrDefault().Nik = employee.Nik;
         Repository.AllEmpoyees.Where(e => e.Name == empname).FirstOrDefault().Email = employee.Email;
         Repository.AllEmpoyees.Where(e => e.Name == empname).FirstOrDefault().NoHandphone = employee.NoHandphone;

         return RedirectToAction("Index");
    }

    //Fungsi Delete
   [HttpPost]
   public IActionResult Delete(string empname)
   {
    Pasien.pasien = Repository.AllPasien.Where(e => e.Name == empname).FirstOrDefault();
    Repository.Delete(pasien);
    return RedirectToAction("Index");
   }
}