using AutoMapper;
using CleanArchMvc.Application.Dtos;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task Add(ProductDTO productDTO)
        {
            var entity = _mapper.Map<Product>(productDTO);
            await _productRepository.CreateAsync(entity);
        }

        public async Task<ProductDTO> GetById(int? id)
        {
            var entity = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDTO>(entity);
        }

        public async Task<ProductDTO> GetProductCategory(int? id)
        {
            var entity = await _productRepository.GetProductCategoryAsync(id);
            return _mapper.Map<ProductDTO>(entity);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var list = await _productRepository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(list);
        }

        public async Task Remove(int? id)
        {
            var entity = _productRepository.GetByIdAsync(id).Result;
            await _productRepository.RemoveAsync(entity);
        }

        public async Task Update(ProductDTO productDTO)
        {
            var entity = _mapper.Map<Product>(productDTO);
            await _productRepository.UpdateAsync(entity);
        }
    }
}
