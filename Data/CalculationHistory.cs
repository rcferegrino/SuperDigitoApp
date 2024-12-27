namespace SuperDigitoApp.Data;

    public class CalculationHistory
    {
        public int Id { get; set; } // Primary Key
        public int Number { get; set; } // Input number
        public string? Result { get; set; } // Result of the calculation
        public DateTime DateTime { get; set; } // Date and time of calculation
        // Foreign Key to ApplicationUser
        public string? UserId { get; set; } // Foreign Key
        public ApplicationUser User { get; set; } // Navigation Property
    }
