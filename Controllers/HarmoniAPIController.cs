using HarmoniBackendAdmin.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HarmoniBackendAdmin.Models;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace MyApp.Namespace
{
    
    [ApiController]
    public class HarmoniAPIController : ControllerBase
    {

        private readonly HarmoniDbContext _context;

        public HarmoniAPIController(HarmoniDbContext context){
            _context = context;
        }
        //Get for products
[Route("api/product")]
[HttpGet]
[Consumes("application/json")]
public async Task <IActionResult> GetProducts(){
    if (_context.Products == null){
        return NotFound();
    }
    return Ok(await _context.Products.ToListAsync());
}
//Get for treatments
[Route("api/treatment")]
[HttpGet]
[Consumes("application/json")]
public async Task <IActionResult> GetTreatments(){
    if (_context.Treatments == null){
        return NotFound();
    }
    return Ok(await _context.Treatments.ToListAsync());
}
//Get for staff
[Route("api/staff")]
[HttpGet]
[Consumes("application/json")]
public async Task <IActionResult> GetStaff(){
    if (_context.Staffs == null){
        return NotFound();
    }
    return Ok(await _context.Staffs.ToListAsync());
}
//Get for booking
[Route("api/booking")]
[HttpGet]
[Consumes("application/json")]
public async Task <IActionResult> GetBooking(){
    if (_context.Bookings == null){
        return NotFound();
    }
    return Ok(await _context.Bookings.ToListAsync());
}

//Get for staff
[Route("api/booking")]
[HttpPost]
[Consumes("application/json")]
public async Task<ActionResult<Booking>> PostBooking(Booking booking){
                _context.Bookings.Add(booking);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetBooking), new { id = booking.Id }, booking);
}
}
}