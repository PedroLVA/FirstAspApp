﻿using FirstAspApp.Interfaces;
using FirstAspApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAspApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IDeveloperRepository _developerRepository;

        public DeveloperController(IDeveloperRepository developerRepository)
        {
            _developerRepository = developerRepository;
        }


        [HttpGet]
        public async Task<ActionResult<Developer>> GetAllDevelopers()
        {
            var developers = await _developerRepository.GetAllDevelopers();
            return Ok(developers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Developer>> GetDeveloper(int id)
        {
            var foundDeveloper = await _developerRepository.GetDeveloperById(id);
            return Ok(foundDeveloper);
        }

        [HttpPost]
        public async Task<ActionResult<Developer>> AddDeveloper(Developer developer)
        {
            if (await _developerRepository.GetDeveloperByName(developer.Name) != null)
            {
                return BadRequest("Developer with that name already exists");
            }

            var addedDeveloper = await _developerRepository.AddDeveloper(developer);
            return Ok(addedDeveloper);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDeveloper(int id)
        {
            await _developerRepository.DeleteDeveloper(id);
            return Ok("Deleted developer with Id " + id + " successfully!");
        }

        [HttpPut]
        public async Task<ActionResult> UpdateDeveloper(Developer developer)
        {
            await _developerRepository.UpdateDeveloper(developer);
            return Ok("Updated developer with Id " + developer.Id + " successfully!");
        }
    }
}
