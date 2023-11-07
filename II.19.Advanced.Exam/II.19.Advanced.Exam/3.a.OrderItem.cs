﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._19.Advanced.Exam
{
    public class OrderItem
    {
        public int TableID { get; set; }
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int MenuNo { get; set; }    
        public int Quantity { get; set; }
        public double Price { get; set; }
        public bool IsPaid { get; set; }
    }
}
