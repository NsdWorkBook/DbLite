﻿namespace DbLite.Replication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class ReplicationOptions
    {
        public string[] InstanceNames { get; set; }

        /// <summary>
        /// Validates the options defined.
        /// </summary>
        /// <exception cref="InvalidReplicationOptionException">If one or more options are incorrect</exception>
        public void Validate()
        {
            if (InstanceNames == null || InstanceNames.Length == 0)
                throw new InvalidReplicationOptionException("Replication Options must have one or more InstanceNames defined");
        }
    }
}