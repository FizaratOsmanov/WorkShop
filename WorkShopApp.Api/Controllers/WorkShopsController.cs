using Microsoft.AspNetCore.Mvc;
using WorkShopApp.BL.DTOs.WorkShopDTOs;
using WorkShopApp.BL.Services.Abstractions;

namespace WorkShopApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkShopsController : ControllerBase
    {
        private readonly IWorkShopService _workShopService;
        public WorkShopsController(IWorkShopService workShopService)
        {
            _workShopService = workShopService;
        }



        [HttpGet]
        public async Task<IActionResult> GetAllWorkShop()
        {
            var workShops = await _workShopService.GetAllAsync();
            return Ok(workShops);
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorkShopById(int id)
        {
            var department = await _workShopService.GetByIdAsync(id);
            return Ok(department);
        }



        [HttpPost]
        public async Task<IActionResult> CreateWorkShop(CreateWorkShopDTO dto)
        {
            await _workShopService.CreateWorkShopAsync(dto);
            return Ok(dto);
        }
    }
}
