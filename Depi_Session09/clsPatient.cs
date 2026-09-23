namespace Depi_Session09
{
    // Q1) Class with a PRIMARY CONSTRUCTOR (C# 12).
    // The parameters are written right after the class name.
    // Note: primary-constructor parameters of a normal class are NOT properties,
    // so we expose them as read-only properties to be able to read them outside the class
    // (the mapper needs Id, FullName and PhoneNumber).
    public class Patient(int Id, string FullName, string PhoneNumber, string MedicalHistory)
    {
        public int Id { get; } = Id;
        public string FullName { get; } = FullName;
        public string PhoneNumber { get; } = PhoneNumber;
        public string MedicalHistory { get; } = MedicalHistory;

        public override string ToString()
        {
            return $"Id: {Id} :: FullName: {FullName} :: PhoneNumber: {PhoneNumber} :: MedicalHistory: {MedicalHistory}";
        }
    }
}
