﻿namespace DbLite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class KeyAttribute : Attribute
    {
    }
}
