﻿using EyeTaxi_WPF.MVVM.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeTaxi_WPF.MVVM.Models.DerivedClasses
{
    public class Admin : Human
    {
        public override string SubFilePath { get => "dataset"; }

        public Admin() : base() { }
    }
}
