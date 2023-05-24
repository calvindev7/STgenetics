using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STgenetics.Data;
using STgenetics.Models;

public class AnimalsController : Controller
{
    private readonly STgeneticsContext _context;

    public AnimalsController(STgeneticsContext context)
    {
        _context = context;
    }

    // GET: Animals
    public async Task<IActionResult> Index()
    {
        var viewModel = new AnimalViewModel
        {
            Animales = await _context.Animal.ToListAsync(),
            Animal = new Animal()
        };

        return View(viewModel);
    }

    // GET: Animals/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.Animal == null)
        {
            return NotFound();
        }

        var animal = await _context.Animal
            .FirstOrDefaultAsync(m => m.AnimalId == id);
        if (animal == null)
        {
            return NotFound();
        }

        return View(animal);
    }


    // POST: Animals/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("AnimalId,Nombre,Raza,FechaNacimiento,Sexo,Precio,Estado")] Animal animal)
    {
        if (ModelState.IsValid)
        {
            animal.AnimalId = _context.Animal.Max(a => a.AnimalId) + 1;
            _context.Add(animal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        var viewModel = new AnimalViewModel
        {
            Animales = await _context.Animal.ToListAsync(),
            Animal = animal
        };

        return View("Index", viewModel);
    }

    // GET: Animals/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.Animal == null)
        {
            return NotFound();
        }

        var animal = await _context.Animal.FindAsync(id);
        if (animal == null)
        {
            return NotFound();
        }
        return View(animal);
    }

    // POST: Animals/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("AnimalId,Nombre,Raza,FechaNacimiento,Sexo,Precio,Estado")] Animal animal)
    {
        if (id != animal.AnimalId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(animal);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimalExists(animal.AnimalId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(animal);
    }

    // GET: Animals/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.Animal == null)
        {
            return NotFound();
        }

        var animal = await _context.Animal
            .FirstOrDefaultAsync(m => m.AnimalId == id);
        if (animal == null)
        {
            return NotFound();
        }

        return View(animal);
    }

    // POST: Animals/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.Animal == null)
        {
            return Problem("Entity set 'STgeneticsContext.Animal' is null.");
        }
        var animal = await _context.Animal.FindAsync(id);
        if (animal != null)
        {
            _context.Animal.Remove(animal);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool AnimalExists(int id)
    {
        return (_context.Animal?.Any(e => e.AnimalId == id)).GetValueOrDefault();
    }
}
