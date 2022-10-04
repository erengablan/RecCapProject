using Entitiy.Abstrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy.Concreate
{
    public class Color : IEntitiy
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public string ColorHexCode { get; set; }
    }
}
