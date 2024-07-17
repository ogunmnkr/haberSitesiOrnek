using Microsoft.AspNetCore.Mvc.RazorPages;
using Haber.Repository;
using Haber.Models;
using System.Collections.Generic;
using System.Linq;

namespace Haber.Pages
{
    public class SporModel : PageModel
    {
        private readonly newRepository _repository;

        public SporModel(newRepository repository)
        {
            _repository = repository;
            NewsList = new List<New>();
        }

        public IEnumerable<New> NewsList { get; private set; }

        public void OnGet()
        {
            NewsList = _repository.GetAll().Where(n => n.Type == "Spor");
        }
    }
}