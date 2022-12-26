using MediatR;
using WebApplication1.DTOs;

namespace WebApplication1.MediatR.Queries
{
    public class GetProductQuery:IRequest<ProductGetDTO>
    {
        public int Id { get; set; }

    }
}
