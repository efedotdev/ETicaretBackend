using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApı.Application.Cqrs.Queries.ProductImageFile.GetProductImages;

namespace ETicaretApı.Application.Cqrs.Queries.ProductImageFile.GetProductImages
{
    public class GetProductImagesQueryRequest : IRequest<List<GetProductImagesQueryResponse>>
    {
        public string Id { get; set; }
    }
}