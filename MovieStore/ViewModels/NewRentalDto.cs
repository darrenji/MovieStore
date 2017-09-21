using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.ViewModels
{
    public class NewRentalDto
    {
        public int CusotmerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}