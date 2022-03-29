
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // [HttpGet("{username}", Name = "GetUser")]
        // public async Task<ActionResult<MemberDto>> GetUser(string username)
        // {
        //     return await _unitOfWork.UserRepository.GetMemberAsync(username);
        // }
    }
}