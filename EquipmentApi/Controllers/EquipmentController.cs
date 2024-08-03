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
            var pathSplited = path.Split('/');           
            var id = nodes.GetNodeIdByPath(pathSplited);
            if(id != -1)
                return Ok(new { Id = id });
            return BadRequest();
        }
    }
}
