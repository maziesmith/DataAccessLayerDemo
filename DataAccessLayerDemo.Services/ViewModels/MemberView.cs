﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerDemo.Services.ViewModels
{
    public class MemberView
    {
        public string MemberId { get; set; }
        public string FullName { get; set; }
        public IList<LoanView> Loans { get; set; }
    }
}
