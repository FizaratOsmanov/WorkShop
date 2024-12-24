using Microsoft.AspNetCore.Mvc;
using WorkShopApp.BL.DTOs.ParticipantDTOs;
using WorkShopApp.BL.DTOs.WorkShopDTOs;
using WorkShopApp.BL.Services.Abstractions;

namespace WorkShopApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantsController : ControllerBase
    {
        private readonly IParticipantService _participantService;
        public ParticipantsController(IParticipantService participantService)
        {
            _participantService = participantService;
        }



        [HttpGet]
        public async Task<IActionResult> GetAllParticipant()
        {
            var workShops = await _participantService.GetAllParticipantAsync();
            return Ok(workShops);
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetParticipantById(int id)
        {
            var part = await _participantService.GetParticipantByIdAsync(id);
            return Ok(part);
        }



        [HttpPost]
        public async Task<IActionResult> CreateParticipant(CreateParticipantDTO dto)
        {
            await _participantService.CreateParticipantAsync(dto);
            return Ok(dto);
        }

    }
}
