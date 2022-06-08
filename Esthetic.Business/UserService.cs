using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Esthetic.Core.Contracts.UnitOfWork;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Domain;
using Esthetic.Model;
using Esthetic.Service.Contracts;

namespace Esthetic.Service
{
    public class UserService : Core.Contracts.ServiceBase.Service, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<OperationClaim> GetClaims(UserLoginResponseModel user)
        {
            return null;
            // return _userRepository.GetClaims(user);
        }

        public bool Add(UserRegisterRequestModel userRegisterRequestModel, byte[] passwordHash, byte[] passwordSalt)
        {
            var user = _mapper.Map<User>(userRegisterRequestModel);

            if (user != null && passwordHash.Length > 0 && passwordSalt.Length > 0)
            {
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            _userRepository.Add(user);
            return _unitOfWork.SaveChanges() > 0;
        }

        public User GetById(int id)
        {
            return _userRepository.FirstOrDefault(u => u.Id == id);
        }

        public User GetByMail(string email)
        {
            return _userRepository.FirstOrDefault(u => u.Email == email);
        }
    }
}