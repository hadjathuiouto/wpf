using System.Collections.Generic;
using TutoWpf.Models;

namespace TutoWpf.Data
{
    public interface IDailyService
    {
        IEnumerable<Daily> GetAll();
    }
}