using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Water.Domain.Models;
using Water.Web.Models.Mapping;

namespace Water.Web.Models
{
    /// <summary>
    /// Товар
    /// </summary>
    public class ProductViewModel : IHaveCustomMappings
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Количество в наличии / на складе
        /// </summary>
        public int InStock { get; set; }


        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Product, ProductViewModel>("Product");

            configuration.CreateMap<ProductViewModel, Product>("Product");
        }
    }

}
