using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities;

public class Tarefa
{
    public long Id { get; set; }
    public string? Descricao {  get; set; }
    public DateTime Data { get; set; }
    public bool Concluida { get; set; }
}
