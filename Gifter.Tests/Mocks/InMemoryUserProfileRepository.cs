using Gifter.Models;
using Gifter.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gifter.Tests.Mocks
{
 class InMemoryUserProfileRepository : IUserProfileRepository
{
        private readonly List<UserProfile> _data;

        public List<UserProfile> InternalData
        {
            get
            {
                return _data;
            }
        }

        public InMemoryUserProfileRepository(List<UserProfile> startingData)
        {
            _data = startingData;
        }
        public void Add(UserProfile user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserProfile> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserProfile GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserProfile GetUserAndPosts(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserProfile user)
        {
            throw new NotImplementedException();
        }
    }
}