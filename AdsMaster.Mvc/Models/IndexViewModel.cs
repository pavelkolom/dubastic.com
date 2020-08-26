using AdsMaster.DB.Models;
using System.Collections.Generic;

namespace AdsMaster.Mvc.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Topic> Items { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
