using MediatR;
using WebApplication1.DTOs;

namespace WebApplication1.MediatR.Commands
{
    public class CreateProductCommand:IRequest<ProductCreateDTO>
    {
        //burada userdən almaq istədiyimiz dataları qeyd edirik.
        public string Name { get; set; } = string.Empty;
        public int Amount { get; set; }
        public decimal Price { get; set; }


        

    }
}
