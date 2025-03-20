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
    
    /// <summary>
    /// Cria um contato
    /// </summary>
    /// <param name="contato"></param>
    /// <returns> </returns>
    [HttpPost]
    public IActionResult Create(Contato contato)
    {
        _context.Add(contato);
        _context.SaveChanges();
        return Ok(null);
    }
    
    /// <summary>
    /// Retorna um contato pelo seu id
    /// </summary>
    /// <param name="id">id do contato</param>
    /// <returns>contato caso encontrado, NotFound() caso n o encontrado</returns>
    [HttpGet("{id}")]
    public IActionResult Read(int id)
    {
        var contato = _context.Contatos.Find(id);
        
        if (contato == null)
        {
            return NotFound();
        }
        
        return Ok(contato);
    }
    
    /// <summary>
    /// Atualiza um contato
    /// </summary>
    /// <param name="id">id do contato</param>
    /// <param name="contato">dados do contato a ser atualizado</param>
    /// <returns>Not Found() caso n o encontrado, Ok() caso encontrado</returns>
    [HttpPut("{id}")]
    public IActionResult Update(int id, Contato contato)
    {
        var data = _context.Contatos.Find(id);
        
        if (data == null)
        {
            return NotFound();
        }
        
        data.Nome = contato.Nome;
        data.Telefone = contato.Telefone;
        data.Email = contato.Email;
        data.Ativo = contato.Ativo;
        
        _context.SaveChanges();
        return Ok(null);
    }
    
    /// <summary>
    /// Remove um contato
    /// </summary>
    /// <param name="id">id do contato</param>
    /// <returns>NotFound() caso n o encontrado, Ok() caso encontrado</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var contato = _context.Contatos.Find(id);
        
        if (contato == null)
        {
            return NotFound();
        }
        
        _context.Contatos.Remove(contato);
        _context.SaveChanges();
        return Ok(null);
    }
    
}
