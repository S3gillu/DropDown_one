using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace try_dropdown.Models
{
    public class DataContext :DbContext
    {
        public DataContext() : base("shu") { }
    }
}