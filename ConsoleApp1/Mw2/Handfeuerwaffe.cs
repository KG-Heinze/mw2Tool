﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class Handfeuerwaffe : Secondary
    {
        public Handfeuerwaffe()
        {

        }

        public Handfeuerwaffe(String name, String[] aufsätze, String[] tarnung)
        {
            this.Name = name;
            this.Aufsätze = aufsätze;
            this.Tarnung = tarnung;
        }

        public Handfeuerwaffe(String name, String[] aufsätze)
        {
            this.Name = name;
            this.Aufsätze = aufsätze;
        }
    }
}
