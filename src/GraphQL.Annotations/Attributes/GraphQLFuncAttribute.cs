﻿using System;

namespace GraphQL.Annotations.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public class GraphQLFuncAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Type ReturnType { get; set; }
    }
}