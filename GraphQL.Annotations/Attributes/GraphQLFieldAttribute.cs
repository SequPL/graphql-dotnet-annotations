﻿using System;

namespace GraphQL.Annotations.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class GraphQLFieldAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ColumnName { get; set; }
        public Type ReturnType { get; set; }
    }
}