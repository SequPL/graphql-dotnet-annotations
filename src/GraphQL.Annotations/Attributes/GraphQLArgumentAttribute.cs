﻿using System;

namespace GraphQL.Annotations.Attributes
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public class GraphQLArgumentAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Type GraphType { get; set; }
    }
}
