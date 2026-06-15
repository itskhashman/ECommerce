using AutoMapper;
using ECommerce.Application.DTOs.Address;
using ECommerce.Application.DTOs.Lookups;
using ECommerce.Application.DTOs.User;
using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities.Users;


namespace ECommerce.Application.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<UserDto>?> GetAllUsersAsync()
        {
            var users =  await _userRepository.GetAllUsersAsync();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }
        public async Task<UserDto?> GetUserByEmailAsync(string email)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            if (user == null)
                return null;
            return _mapper.Map<UserDto>(user);
        }
        public async Task<IEnumerable<UserDto>> GetUsersByRoleAsync(int roleId)
        {
            var users = await _userRepository.GetUsersByRoleAsync(roleId);
            return users.Select(user => _mapper.Map<UserDto>(user));
        }
        public async Task<string?> GetUserRoleAsync(int userId)
        {
            return await _userRepository.GetUserRoleAsync(userId);
        }

        public async Task<UserDto?> GetUserWithAddressesAsync(int userId)
        {
            var user = await _userRepository.GetUserWithAddressesAsync(userId);
            return _mapper.Map<UserDto>(user);
        }
        public async Task AssignRoleToUserAsync(int userId, int roleId)
        {
            await _userRepository.AssignRoleToUserAsync(userId, roleId);
        }
        public async Task<UserDto?> UpdateUserInfo(UpdateUserDto user)
        {
            var userEntity = _mapper.Map<User>(user);
            await _userRepository.UpdateUserInfo(userEntity, user.RoleId);
            var updatedUser = await _userRepository.GetUserWithAddressesAsync(user.Id);
            return updatedUser == null ? null : _mapper.Map<UserDto>(updatedUser);
        }   
        public async Task<UserDto?> AddUserAddress(int userId, AddressDto address)
        {
            var addressEntity = _mapper.Map<Address>(address);
            await _userRepository.AddUserAddress(userId, addressEntity);
            var user = await _userRepository.GetUserWithAddressesAsync(userId);
            return user == null ? null : _mapper.Map<UserDto>(user);
        }
        public async Task<UserDto?> UpdateUserAddress(int userId, AddressDto address)
        {
            var addressEntity = _mapper.Map<Address>(address);
            await _userRepository.UpdateUserAddress(userId, addressEntity);
            var user = await _userRepository.GetUserWithAddressesAsync(userId);
            return user == null ? null : _mapper.Map<UserDto>(user);
        }
        public async Task<UserDto?> DeleteUserAddress(int userId, int addressId)
        {
            await _userRepository.DeleteUserAddress(userId, addressId);
            var user = await _userRepository.GetUserWithAddressesAsync(userId);
            return user == null ? null : _mapper.Map<UserDto>(user);
        }
        public async Task<IEnumerable<AddressDto>> GetUserAddressesAsync(int userId)
        {
            var addresses = await _userRepository.GetUserAddressesAsync(userId);
            return addresses.Select(address => _mapper.Map<AddressDto>(address));
        }
        public async Task<IEnumerable<CityDto>> GetAllCitiesAsync()
        {
            var cities = await _userRepository.GetAllCitiesAsync();
            return cities.Select(city => _mapper.Map<CityDto>(city));
        }
        public async Task<IEnumerable<CountryDto>> GetAllCountriesAsync()
        {
            var countries = await _userRepository.GetAllCountriesAsync();
            return countries.Select(country => _mapper.Map<CountryDto>(country));
        }
    }
}