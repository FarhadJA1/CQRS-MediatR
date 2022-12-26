using MediatR;
using WebApplication1.DTOs;

namespace WebApplication1.MediatR.Queries
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductGetDTO>
    {
        public Task<ProductGetDTO> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var model = new ProductGetDTO()
            {
                Id = 1,
                Name = "Salam"
            };
            return Task.FromResult(model);
        }
    }
}
