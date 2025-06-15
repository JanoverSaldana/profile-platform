using profile_platform.profiles.Domain.Model.ValueObjects;

namespace profile_platform.profiles.Interfaces.REST.Resources;

public record CreateUserResource(
    string name, 
    string street, 
    string city, 
    string country, 
    string postalCode, 
    Gender gender);
    
