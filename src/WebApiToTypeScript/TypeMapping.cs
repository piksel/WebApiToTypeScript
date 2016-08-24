﻿namespace WebApiToTypeScript
{
    public class TypeMapping
    {
        public string WebApiTypeName { get; set; }
        public string TypeScriptTypeName { get; set; }

        public bool TreatAsAttribute { get; set; }
            = false;

        public bool AutoInitialize { get; set; }
            = false;
    }
}