using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsRazor.Data;
using DevOpsRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevOpsRazor.Pages.StudioPages
{
    public class AllStudiosModel : PageModel
    {
        private Repo repo;
        public List<Studio> Studios { get; set; }
        public AllStudiosModel()
        {
            repo = new Repo();
        }
        public void OnGet()
        {
            Studios = repo.GetAllStudios().ToList();

        }
    }
}
