using MediatR;
using WebApplication1.DTOs;

namespace WebApplication1.MediatR.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductCreateDTO>
    {
        public Task<ProductCreateDTO> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var model = new ProductCreateDTO()
            {
                Id = 100,
                Name = request.Name,
                Amount = request.Amount,
                Price = request.Price,
            };
            return Task.FromResult(model);
        }
    }
}
