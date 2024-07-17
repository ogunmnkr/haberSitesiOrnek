using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Haber.Repository;
using Haber.Models;

namespace Haber.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly newRepository _repository;

        public DetailsModel(newRepository repository)
        {
            _repository = repository;
        }

        public New? News { get; private set; }

        public IActionResult OnGet(int id)
        {
            News = _repository.GetById(id);

            if (News == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
