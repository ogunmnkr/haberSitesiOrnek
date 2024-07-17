using Haber.Models;
using System.Collections.Generic;

namespace Haber.Repository
{
    public interface newRepository
    {
        IEnumerable<New> GetAll();
        New GetById(int id);
    }
}