using CarvedRock.Api.Model;
using CarvedRock.Api.Repositories;
using GraphQL.DataLoader;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api.GraphQL.Type
{
    public class ProductType: ObjectGraphType<Product>
    {
        public ProductType(ProductReviewRepository reviewRepository, IDataLoaderContextAccessor dataLoaderContextAccessor)
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Description);
            Field(t => t.IntroducedAt).Description("When the product was first intorudced in the catalog");
            Field(t => t.PhotoFileName).Description("The file name of the photo so the client can render it");
            Field(t => t.Price);
            Field(t => t.Rating).Description("The (max 5) star customer rating");
            Field(t => t.Stock);
            Field<ProductTypeEnumType>("Type", "The type of product");


            //inefficient since it will do multiple calls to the database
            Field<ListGraphType<ProductReviewType>>(
                "reviewsDeprecated",
                resolve: context => reviewRepository.GetProduct(context.Source.Id)
                );

            //Better solution using dataLoader
            //This will get all the productIds that we want to reviews for
            //Gets all the review in cache that links to the productIds from the query
            //Field<ListGraphType<ProductReviewType>>(
            //    "reviews",
            //    resolve: context =>
            //    {
            //        var loader = dataLoaderContextAccessor.Context.GetOrAddCollectionBatchLoader<int, ProductReview>(
            //            "GetR")
            //    });


        }
    }
}
 