﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laba9.Models
{
    public class order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Address { get; set; }
    }
}