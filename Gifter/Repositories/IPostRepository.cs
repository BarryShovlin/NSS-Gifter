using Gifter.Models;
using System.Collections.Generic;

namespace Gifter.Repositories
{
    public interface IPostRepository
    {
        void Add(Post post);
        void Delete(int id);
        List<Post> GetAll();
        List<Post> GetAllWithComments();
        Post GetById(int id);
        void Update(Post post);
        Post GetByIdWithComments(int id);
        List<Post> Search(string criterion, bool sortDescending);
        List<Post> Hottest(string since);
    }
}