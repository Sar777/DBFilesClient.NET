﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBFilesClient.NET
{
    /// <summary>
    /// Controls how the property is used by storage.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class StoragePresenceAttribute : Attribute
    {
        internal static readonly Type Type = typeof(StoragePresenceAttribute);

        public StoragePresenceOption Option { get; private set; }
        public string PropertyName { get; set; }

        public StoragePresenceAttribute(StoragePresenceOption option)
        {
            this.Option = option;
        }
    }
}