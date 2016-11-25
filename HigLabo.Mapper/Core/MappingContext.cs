﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.Core
{
    public class MappingContext
    {
        private List<KeyValuePair<Object, Object>> _MappedObjectPair = new List<KeyValuePair<Object, Object>>();

        internal Int32 CallStackCount { get; set; }
        public StringComparer DictionaryKeyStringComparer { get; set; }
        public CollectionElementMapMode CollectionElementMapMode { get; set; }

        public MappingContext(StringComparer stringComparer, CollectionElementMapMode collectionElementMapMode)
        {
            this.DictionaryKeyStringComparer = stringComparer;
            this.CollectionElementMapMode = collectionElementMapMode;
        }
        public Boolean Exists(KeyValuePair<Object, Object> value)
        {
            if (_MappedObjectPair.Contains(value) == true) { return true; }
            _MappedObjectPair.Add(value);
            return false;
        }
    }
}
