using Microsoft.AspNetCore.Mvc.RazorPages;
using Haber.Repository;
using Haber.Models;
using System.Collections.Generic;
using System.Linq;

namespace Haber.Pages
{
    public class EkonomiModel : PageModel
    {
        private readonly newRepository _repository;

        public EkonomiModel(newRepository repository)
        {
            _repository = repository;
            NewsList = new List<New>();
        }

        public IEnumerable<New> NewsList { get; private set; }

// Sayfa yüklendiğinde NewsList içini doldurmak için OnGet metodu ;
        public void OnGet()
        {
            NewsList = _repository.GetAll().Where(n => n.Type == "Ekonomi");
        }
    }
}