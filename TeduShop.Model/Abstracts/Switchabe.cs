﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstracts
{
    public abstract class Switchable : ISwitchable
    {
        
        public bool Status
        {
            get;
            set;
        }
        
    }
}
