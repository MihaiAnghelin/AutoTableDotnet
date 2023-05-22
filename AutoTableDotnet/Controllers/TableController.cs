using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace AutoTableDotnet.Controllers;

[ApiController, Route("api/table")]
public class TableController : Controller
{
    private static readonly RestClientOptions Options = new("http://192.168.100.69");
    private static readonly RestClient Client = new(Options);

    [Authorize]
    [HttpGet("toggle")]
    public async Task<IActionResult> ToggleTable()
    {
        var request = new RestRequest("toggle");
        var response = await Client.GetAsync(request);

        return Ok(response.Content);
    }

    [Authorize]
    [HttpGet("status")]
    public async Task<IActionResult> GetStatus()
    {
        var request = new RestRequest("status");
        var response = await Client.GetAsync(request);

        return Ok(response.Content);
    }
}