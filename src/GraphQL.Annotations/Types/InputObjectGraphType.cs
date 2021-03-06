﻿using GraphQL.Types;

namespace GraphQL.Annotations.Types
{
    public class InputObjectGraphType<TModelType> : InputObjectGraphType
    {
        public InputObjectGraphType()
        {
            this.ApplyTypeData<TModelType>();
            this.ApplyProperties<TModelType>();
        }

        public override string ToString()
        {
            return Name + " - Input Object Type";
        }
    }
}
