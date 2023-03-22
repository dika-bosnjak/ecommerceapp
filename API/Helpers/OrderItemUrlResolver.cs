using API.Dtos;
using AutoMapper;
using Core.Entities.OrderAggregate;

namespace API.Helpers
{
    public class OrderItemUrlResolver : IValueResolver<OrderItem, OrderItemDto, string>
    {
        public IConfiguration _config { get; }
        public OrderItemUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(OrderItem source, OrderItemDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.ItemOrdered.PictureUrl) && !source.ItemOrdered.PictureUrl.Contains("http"))
            {
                return _config["ApiUrl"] + source.ItemOrdered.PictureUrl;
            }

            return source.ItemOrdered.PictureUrl;
        }
    }
}