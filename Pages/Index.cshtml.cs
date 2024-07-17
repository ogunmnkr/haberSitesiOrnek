using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Haber.Repository;
using Haber.Models;
using System.Collections.Generic;

namespace Haber.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly newRepository _repository;

        public IndexModel(ILogger<IndexModel> logger, newRepository repository)
        {
            _logger = logger;
            _repository = repository;
            NewsList = new List<New>();
        }

        public IEnumerable<New> NewsList { get; private set; }

        public void OnGet()
        {
            NewsList = _repository.GetAll();
        }
    }
}