using Microsoft.AspNetCore.Mvc;
using proeventos.back.Data;
using proeventos.back.Models;

namespace proeventos.back.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly AppDataContext _context;
    public EventoController(AppDataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;

    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
        return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);

    }

    [HttpPost]
    public string Post()
    {
        return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de Put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de Delete com id = {id}";
    }
}
