using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi.Context;

public class PlannerContext : DbContext
{
    public PlannerContext(DbContextOptions<PlannerContext> options) : base(options) 
    {
        
    }
    
    public DbSet<Contato> Contatos { get; set; }
    public DbSet<Tarefa> TodoList { get; set; }  
}
