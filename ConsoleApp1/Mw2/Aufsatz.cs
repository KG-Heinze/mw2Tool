﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    
    class Aufsatz
    {
        private String name = null;
        private String typ = null;

        public Aufsatz()
        {

        }
        public Aufsatz(String name, String typ)
        {
            this.name = name;
            this.typ = typ;
        }

        public String Name { get => name; set => name = value; }
        public String Typ { get => typ; set => typ = value; }
    }
}
