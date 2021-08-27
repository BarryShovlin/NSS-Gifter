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
            var lastUserProfile = _data.Last();
            user.Id = lastUserProfile.Id + 1;
            _data.Add(user);
        }

        public void Delete(int id)
        {
            var userProfileToDelete = _data.FirstOrDefault(u => u.Id == id);
            if (userProfileToDelete == null )
            {
                return;
            }
            _data.Remove(userProfileToDelete);
        }

        public List<UserProfile> GetAll()
        {
            return _data;
        }

        public UserProfile GetById(int id)
        {
            return _data.FirstOrDefault(u => u.Id == id);
        }

        public UserProfile GetUserAndPosts(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserProfile user)
        {
            var currentUserProfile = _data.FirstOrDefault(u => u.Id == user.Id);

            if (currentUserProfile == null)
            {
                return;
            }

            currentUserProfile.Name = user.Name;
            currentUserProfile.Email = user.Email;
            currentUserProfile.Bio = user.Bio;
            currentUserProfile.ImageUrl = user.ImageUrl;
            currentUserProfile.DateCreated = user.DateCreated;
        }
    }
}