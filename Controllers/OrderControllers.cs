private readonly AppDbContext _context;

public OrdersController(AppDbContext context)
{
    _context = context;
}

// GET: Orders
public async Task<IActionResult> Index()
{
    var appDbContext = _context.Orders.Include(o => o.Vendor);
    return View(await appDbContext.ToListAsync());
}

// GET: Orders/Create
public IActionResult Create()
{
    ViewData["VendorId"] = new SelectList(_context.Vendors, "Id", "Name");
    return View();
}

// POST: Orders/Create
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Create([Bind("Id,Description,Amount,Date,VendorId")] Order order)
{
    if (ModelState.IsValid)
    {
        _context.Add(order);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    ViewData["VendorId"] = new SelectList(_context.Vendors, "Id", "Name", order.VendorId);
    return View(order);
}

// GET: Orders/Edit/5
public async Task<IActionResult> Edit(int? id)
{
    if (id == null)
    {
        return NotFound();
    }

    var order = await _context.Orders.FindAsync(id);
    if (order == null)
    {
        return NotFound();
    }
    ViewData["VendorId"] = new SelectList(_context.Vendors, "Id", "Name", order.VendorId);
    return View(order);
}

// POST: Orders/Edit/5
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Amount,Date,VendorId")] Order order)
{
    if (id != order.Id)
    {
        return NotFound();
    }

    if (ModelState.IsValid)
    {
        try
        {
            _context.Update(order);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!OrderExists(order.Id))
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
    ViewData["VendorId"] = new SelectList(_context.Vendors, "Id", "Name", order.VendorId);
    return View(order);
}

// GET: Orders/Details/5
public async Task<IActionResult> Details(int? id)
{
    if (id == null)
    {
        return NotFound();
    }

    var order = await _context.Orders
        .Include(o => o.Vendor)
        .FirstOrDefaultAsync(m => m.Id == id);
    if (order == null)
    {
        return NotFound();
    }

    return View(order);
}

private bool OrderExists(int id)
{
    return _context.Orders.Any(e => e.Id == id);
}
