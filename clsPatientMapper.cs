namespace Depi_Session09
{
    // Q4) Static class = cannot be instantiated, contains only static members.
    public static class PatientMapper
    {
        public static PatientDto MapFromModelToDto(Patient patient)
        {
            return new PatientDto(patient.Id, patient.FullName, patient.PhoneNumber);
        }
    }
}
