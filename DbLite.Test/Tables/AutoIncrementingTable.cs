﻿namespace DbLite.Test.Tables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AutoIncrementingTable
    {
        [Key]
        public int Id { get; set; }

        public string Value { get; set; }
    }
}
