﻿using Scrummer.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrummer.Domain.Standups
{
    public class ActionItem: Entity
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string AssignedTo { get; set; }

    }
}
