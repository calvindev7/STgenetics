using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STgenetics.Data;
using STgenetics.Models;

public class AnimalsController : Controller
{
    private readonly STgeneticsContext _context;
    private List<Animal> animalesSeleccionados = new List<Animal>();

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

    [HttpPost]
    public ActionResult ProcesarPedido(List<int> animalIds)
    {
        foreach (int id in animalIds)
        {
            Animal animal = _context.Animal.FirstOrDefault(a => a.AnimalId == id);
            if (animal != null)
            {
                animalesSeleccionados.Add(animal);
            }
        }

        // Verificación de duplicados en el pedido
        var animalesDuplicados = animalesSeleccionados
            .GroupBy(a => a.Raza)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToList();

        if (animalesDuplicados.Any())
        {
            ModelState.AddModelError("", "No se permite duplicar el animal en el pedido.");
            return RedirectToAction("Index");
        }

        // Cálculos de descuentos y envío
        decimal totalCompra = animalesSeleccionados.Sum(a => a.Precio);
        decimal descuentoAnimal = 0;
        decimal descuentoAdicional = 0;
        decimal envio = 0;

        if (animalesSeleccionados.Count > 5)
        {
            descuentoAnimal = totalCompra * 0.05m;
        }

        if (animalesSeleccionados.Count > 10)
        {
            descuentoAdicional = totalCompra * 0.03m;
        }

        if (animalesSeleccionados.Count > 20)
        {
            envio = 0;
        }
        else
        {
            envio = 1000;
        }

        PedidoViewModel pedido = new PedidoViewModel
        {
            AnimalesSeleccionados = animalesSeleccionados,
            TotalCompra = totalCompra,
            DescuentoAnimal = descuentoAnimal,
            DescuentoAdicional = descuentoAdicional,
            Envio = envio,
            TotalPedido = totalCompra - descuentoAnimal - descuentoAdicional + envio
        };

        return View("ResumenPedido", pedido);
    }
}
