﻿using FirstAspApp.Data;
using FirstAspApp.Interfaces;
using FirstAspApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAspApp.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly VideoGameDbContext _context;

        public PublisherRepository(VideoGameDbContext context) {
            _context = context;
        }

        public async Task<Publisher> AddPublisher(Publisher publisher)
        {
            await _context.Publisher.AddAsync(publisher);

            return publisher;
        }

        public async Task DeletePublisher(int id)
        {
            var foundPublisher = await _context.Publisher.FindAsync(id);

            _context.Publisher.Remove(foundPublisher);
            await _context.SaveChangesAsync();
            return;
        }

        public async Task<List<Publisher>> GetAllPublishers()
        {
            return await _context.Publisher.ToListAsync();
        }

        public async Task<Publisher?> GetPublisherById(int id)
        {
            return await _context.Publisher.FindAsync(id);
        }

        public async Task UpdatePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }
    }
}
