using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsRazor.Models;

namespace DevOpsRazor.Data
{
    public class Repo
    {
        private List<Movie> movies;
        private List<Studio> studios;

        public Repo()
        {
            movies = new List<Movie>();
            studios = new List<Studio>();
            studios.Add(new Studio()
            {
                Name = "Studio 1",
                HQCity = "boston",
                Id = 1,
                NoOfEmployees = 50
            });
            studios.Add(new Studio()
            {
                Name = "Studio 2",
                HQCity = "New York",
                Id = 2,
                NoOfEmployees = 222
            });
        }

        public IEnumerable<Studio> GetAllStudios()
        {
            return studios.ToList();
        }

    }
}
