﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utilities.Log
{
    class WarnLog : BaseLog
    {
        public void Write(string message)
        {
            base.Write(message, "WARN");
        }
    }
}
