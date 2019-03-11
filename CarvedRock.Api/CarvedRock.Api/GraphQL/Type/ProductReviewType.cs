using CarvedRock.Api.Model;
using GraphQL.Types;

namespace CarvedRock.Api.GraphQL.Type
{
    public class ProductReviewType: ObjectGraphType<ProductReview>
    {
        public ProductReviewType()
        {
            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Review);

        }
    }
}
