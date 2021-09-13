using Entities.DTOs;
using Entities.Entities;

namespace Entities.Util
{
    public static class MapperExtensions
    {
        // There are libraries like AutoMapper that could do this job, but I decided to implement this manually.
        // One of the reasons being that I want to show that I can use extension methods. 

        public static BaseDTO ToDTO(this BaseEntity entity)
        {
            if (entity is User)
            {
                return ((User)entity).ToDTO();
            }
            // Add here future DTOs
            else
            {
                return null;
            }
        }

        public static BaseEntity ToEntity(this BaseDTO dto)
        {
            if (dto is UserDTO)
            {
                return ((UserDTO)dto).ToEntity();
            }
            // Add here future entities 
            else
            {
                return null;
            }
        }

        public static UserDTO ToDTO(this User user)
        {
            var userDto = new UserDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username
            };

            return userDto;
        }

        public static User ToEntity(this UserDTO userDto)
        {
            var user = new User
            {
                FirstName = userDto.FirstName,
                LastName =  userDto.LastName,
                Username =  userDto.Username
            };

            return user;
        }
    }
}
