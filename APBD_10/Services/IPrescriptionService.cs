using APBD_10.DTO;
using APBD_10.Models;

namespace APBD_10.Services;

public interface IPrescriptionService
{
    public Task<Prescription> AddPrescriptionAsync(PrescriptionRequestDto request);
    
    public Task<Prescription> GetPrescriptionAsync(int id);
    
}