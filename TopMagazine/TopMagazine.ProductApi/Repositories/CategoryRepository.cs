﻿using Microsoft.EntityFrameworkCore;
using TopMagazine.ProductApi.Context;
using TopMagazine.ProductApi.Models;

namespace TopMagazine.ProductApi.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            //Retorna tudo em memoria, atentar para produção
            return await _context.Categories.ToListAsync();
        }
        public async Task<IEnumerable<Category>> GetCategoriesProducts()
        {
            return await _context.Categories.Include(p => p.Products).ToListAsync();
        }
        public async Task<Category> GetById(int id)
        {
            return await _context.Categories.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Category> Create(Category category)
        {
            _context.Categories.Add(category);

            //Posteriormente implementar padrão UnitOfWork
            await _context.SaveChangesAsync();
            return category;
        }
        public async Task<Category> Update(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> Delete(int id)
        {
            var category = await GetById(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
