using EquipmentApi.EquipmentGraph;
using EquipmentApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace EquipmentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentData _equipmentData;
        public EquipmentController(IEquipmentData equipmentData) 
        {
            _equipmentData = equipmentData;
        }
        [HttpGet]
        public async Task<ActionResult<string>> GetEquipmentIdByPath(string path)
        {
            var nodes = await _equipmentData.GetEquipmentDataAsync();
            var pathQueue = new Queue<string>(path.Split('/').ToList());           
            var id = nodes.GetNodeIdByPath(pathQueue);
            if(id != -1)
                return Ok(new { Id = id });
            return BadRequest();
        }
    }
}
