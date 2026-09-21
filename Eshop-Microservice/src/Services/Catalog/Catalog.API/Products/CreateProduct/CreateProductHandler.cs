using MediatR;

namespace Catalog.API.Products.CreateProduct;
public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
    : IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);
public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public class CreateProductHandler
    {
    }
}
