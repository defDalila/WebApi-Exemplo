using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Context;
using WebApi.Entities;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ContatoController : ControllerBase
{
    // ctor pra receber context pra então fazer o crud
    
    private readonly PlannerContext _context;
    
    public ContatoController(PlannerContext context)
    {
        _context = context;
    }
    
    [HttpPost]
    public IActionResult Create(Contato contato)
    {
        _context.Add(contato);
        _context.SaveChanges();
        return Ok(null);
    }
    
}
