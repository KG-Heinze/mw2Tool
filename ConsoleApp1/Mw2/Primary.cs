﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class Primary : Waffe
    {

        public Primary()
        {
        }

        public Primary(String waffenkategorie, String name, Aufsatz[] aufsätze, String[] tarnung)
        {
            this.Waffenkategorie = waffenkategorie;
            this.Name = name;
            this.Aufsätze = aufsätze;
            this.Tarnung = tarnung;
        }
    }
}
