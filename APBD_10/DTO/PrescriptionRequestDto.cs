﻿namespace APBD_10.DTO;

public class PrescriptionRequestDto
{
    public PatientDto Patient { get; set; }
    public PrescriptionDto Prescription { get; set; }
    public DoctorDto Doctor { get; set; }
    
    
}