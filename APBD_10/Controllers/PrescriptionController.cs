using APBD_10.DTO;
using APBD_10.Models;
using APBD_10.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_10.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class PrescriptionController: ControllerBase
{

    private readonly IPrescriptionService _prescriptionService;


    public PrescriptionController(IPrescriptionService prescriptionService)
    {
        _prescriptionService = prescriptionService;
    }
    
    
    [HttpPost]
    public async Task<ActionResult> AddPrescription(PrescriptionRequestDto request)
    {
        if (request.Prescription.DueDate < request.Prescription.Date)
        {
            return BadRequest("DueDate must be greater than or equal to Date.");
        }

        if (request.Prescription.Medicaments.Count > 10)
        {
            return BadRequest("Prescription cannot include more than 10 medicaments.");
        }

        var prescription = await _prescriptionService.AddPrescriptionAsync(request);
        return CreatedAtAction(nameof(GetPrescription), new { id = prescription.IdPresctiprion }, prescription);
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Prescription>> GetPrescription(int id)
    {
        var prescription = await _prescriptionService.GetPrescriptionAsync(id);
        if (prescription == null)
        {
            return NotFound();
        }
        return Ok(prescription);
    }
}