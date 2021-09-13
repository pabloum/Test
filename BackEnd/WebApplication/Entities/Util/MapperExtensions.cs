using Entities.DTOs;
using Entities.Entities;

namespace Entities.Util
{
    public static class MapperExtensions
    {
        // There are libraries like AutoMapper that could do this job.

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
