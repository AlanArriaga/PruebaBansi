using PruebaBansi.Models;
using PruebaBansi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace PruebaBansi.Controllers;

public class ExamenController : Controller
{
    private readonly ExamenContext _dbContext;
    public ExamenController(ExamenContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> Lista()
    {
        List<Examen> lista = await _dbContext.tbIExamen.ToListAsync();
        return View(lista);
    }

    [HttpGet]
    public IActionResult Registro()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AgregarExamen(Examen examen)
    {
        _dbContext.Add(examen);
        await _dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Lista));
    }

    [HttpGet]
    public async Task<IActionResult> Consultar(int id)
    {
        var examen = await _dbContext.tbIExamen.FindAsync(id);
        if (examen == null)
        {
            return NotFound();
        }
        return View(examen);
        }

    [HttpGet]
    public async Task<IActionResult> Editar(int id)
    {
        Examen examen = await _dbContext.tbIExamen.FirstAsync(e => e.IdExamen == id);
        return View(examen);
    }

    [HttpPost]
    public async Task<IActionResult> ActualizarExamen(Examen examen)
    {
        _dbContext.tbIExamen.Update(examen);
        await _dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Lista));
    }

    [HttpGet]
    public async Task<IActionResult> EliminarExamen(int id)
    {
        Examen examen = await _dbContext.tbIExamen.FirstAsync(e => e.IdExamen == id);
        _dbContext.tbIExamen.Remove(examen);
        await _dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Lista));
    }
}
