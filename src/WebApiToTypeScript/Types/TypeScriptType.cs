﻿namespace WebApiToTypeScript.Types
{
    public class TypeScriptType
    {
        public string TypeName { get; set; }
        public string InterfaceName { get; set; }

        public bool IsEnum { get; set; }
        public bool IsPrimitive { get; set; }

        public int CollectionLevel { get; set; }

        public bool IsMappedType { get; set; }
    }
}