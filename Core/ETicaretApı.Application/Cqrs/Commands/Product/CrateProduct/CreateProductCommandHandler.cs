using ETicaretApı.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApı.Application.Abstractions.Services.Hubs;
using ETicaretApı.Application.ProductRepo;

namespace ETicaretApı.Application.Cqrs.Commands.Product.CreateProduct
{
    public class
        CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductHubService _productHubService;

        public CreateProductCommandHandler(IProductWriteRepository productWriteRepository,
            IProductHubService productHubService)
        {
            _productWriteRepository = productWriteRepository;
            _productHubService = productHubService;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request,
            CancellationToken cancellationToken)
        {
            await _productWriteRepository.AddAsync(new()
            {
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock
            });
            await _productWriteRepository.SaveChangesAsync();
            
            await _productHubService.ProductAddedMessageAsync($"{request.Name} isminde ürün eklenmiştir.");
            return new();
        }
    }
}