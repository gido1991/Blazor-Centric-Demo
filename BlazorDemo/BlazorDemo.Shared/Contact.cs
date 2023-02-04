using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Shared;

public class Contact
{
    public string FirstName { get; set; } = "";

    [Required(ErrorMessage = "Achternaam is verplicht")]
    public string LastName { get; set; } = "";

    [Required(ErrorMessage = "Postcode is verplicht"), MaxLength(6, ErrorMessage = "Postcode is niet valide")]
    public string PostalCode { get; set; } = "";
}