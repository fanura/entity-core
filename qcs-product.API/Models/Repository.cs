using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using qcs_product.API.BindingModels;
using qcs_product.API.BusinessProviders;
using qcs_product.API.ViewModels;

namespace qcs_product.API.Models
{
    public static class Repository
    {
        private static List<Pasien> allPasien = new List<Pasien>();
        
        public static IEnumerable<Pasien> AllPasien
        {
            get { return allPasien; }
        }

        //fungsi create
        public static void Create(Pasien pasien)
        {
            allPasien.Add(pasien);
        }

        //fungsi delete
        public static void Delete(Pasien pasien)
        {
            allPasien.Remove(pasien);
        }
    }
}
