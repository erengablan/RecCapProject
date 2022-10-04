using Entitiy.Abstrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy.Concreate
{
    public class Brand :IEntitiy
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
