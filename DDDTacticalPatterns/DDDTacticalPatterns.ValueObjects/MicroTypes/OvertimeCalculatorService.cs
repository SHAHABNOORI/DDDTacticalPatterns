namespace DDDTacticalPatterns.ValueObjects.MicroTypes
{
    public class OvertimeCalculatorService
    {
        public OvertimeHours Calculate(HoursWorked worked, ContractedHours contracted)
        {
            var overtimeHours = worked.Hours - contracted.Hours;
            return new OvertimeHours(overtimeHours);
        }
    }
}