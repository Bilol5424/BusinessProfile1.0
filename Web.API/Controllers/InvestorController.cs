using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InvestorController(
    IBaseService<Investor> investorService,
    IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var investors = await investorService.GetAllAsync();

        var response = mapper.Map<IEnumerable<GetAllInvestorResponse>>(investors);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateInvestorRequest request)
    {
        await investorService.CreateAsync(mapper.Map<Investor>(request));

        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return Ok();
    }
}