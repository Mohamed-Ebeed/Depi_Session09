namespace Depi_Session09
{
    // Q3) Positional record: exposes only Id, FullName, PhoneNumber (no MedicalHistory).
    // The compiler generates: properties, constructor, ToString, Equals, GetHashCode, ==, !=, Deconstruct.
    public record PatientDto(int Id, string FullName, string PhoneNumber);
}
