﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductService
    {
        public void CreateProduct(string productName, decimal price)
        {
            MessageBox.Show("veri eklendi");
        }
    }
}
