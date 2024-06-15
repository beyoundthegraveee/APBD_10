using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APBD_10.Models;

public class Patient
{
    [Key]
    [Required]
    public int IdPatient { get; set; }
    
    
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    
    [Required]
    public DateTime BirthDate { get; set; }
    
    public virtual ICollection<Prescription> Prescriptions { get; set; }
}