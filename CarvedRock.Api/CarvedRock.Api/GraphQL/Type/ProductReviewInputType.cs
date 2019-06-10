﻿using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api.GraphQL.Type
{
    public class ProductReviewInputType : InputObjectGraphType
    {
        public ProductReviewInputType()
        {
            Name = "reviewInput";
            Field<NonNullGraphType<StringGraphType>>("title");
            Field<StringGraphType>("review");
            Field<NonNullGraphType<IntGraphType>>("productId");
        }
    }
}
