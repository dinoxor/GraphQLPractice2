
using CarvedRock.Api.Model;
using CarvedRock.Api.Repositories;
using GraphQL.Types;
using CarvedRock.Api.GraphQL.Type;

namespace CarvedRock.Api.GraphQL
{
    public class CarvedRockMutation : ObjectGraphType
    {
        public CarvedRockMutation(ProductReviewRepository reviewRepository)
        {
            FieldAsync<ProductReviewType>(
                "createReview",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ProductReviewInputType>> { Name = "review" }),
                resolve: async context =>
                {
                    var review = context.GetArgument<ProductReview>("review");
                    return await context.TryAsyncResolve(
                        async c => await reviewRepository.AddReview(review));
                });

        }
    }
}
