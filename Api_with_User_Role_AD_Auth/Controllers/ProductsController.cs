namespace WebApi.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using System.Collections.Generic;
using System.Data;
using WebApi.Entities;

[ApiController]
[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:scopes")]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
   
    private List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Milo" },
        new Product { Id = 2, Name = "Tim Tams" }
    };

    [HttpGet]
    [Authorize(Roles = "Manager")]
    [Route("[action]")]
    public IActionResult GetAllProduct()
    {
        return Ok(_products);
    }
    [Authorize]

    [HttpGet("{id}")]
    [Route("action")]
    public IActionResult GetById(int id)
    {
        var product = _products.Find(x => x.Id == id);
        if (product == null)
            return NotFound();

        return Ok(product);
    }
}
