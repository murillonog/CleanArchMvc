using AutoMapper;
using CleanArchMvc.Application.Dtos;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task Add(CategoryDTO categoryDTO)
        {
            var entity = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.CreateAsync(entity);
        }

        public async Task<CategoryDTO> GetById(int? id)
        {
            var entity = await _categoryRepository.GetByIdAsync(id);
            return _mapper.Map<CategoryDTO>(entity);
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var list = await _categoryRepository.GetCategoriesAsync();
            return _mapper.Map<IEnumerable<CategoryDTO>>(list);
        }

        public async Task Remove(int? id)
        {
            var entity = _categoryRepository.GetByIdAsync(id).Result;
            await _categoryRepository.RemoveAsync(entity);
        }

        public async Task Update(CategoryDTO categoryDTO)
        {
            var entity = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.UpdateAsync(entity);
        }
    }
}
