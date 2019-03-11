using GraphQL.Types;

namespace CarvedRock.Api.GraphQL.Type
{
    public class ProductTypeEnumType : EnumerationGraphType<Model.ProductType>
    {
        public ProductTypeEnumType()
        {
            Name = "Type";
            Description = "The Type of product";
        }
    }
}
