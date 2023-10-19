using System.ComponentModel.DataAnnotations;

namespace IntroductionToCsharp
{
    internal class Program
    {
        static void Main()
        {
            // Syntax declar variable
            // DataType VariableName = DefaultValue;

            string FirstName;

            /*
                Variable name rules:
                1. _ Names can contain letter, digit, underscore(_).
                2. Names must begin with letter or underscore.
                3. Names are case sensitive(firstName and FirstName are different variable).
                4. Reserved Word (keywords not allowed to the variable name) connot used.
            */
            
            // Example
            char UserOption;
            int Age = 22;
            decimal ParticlesPerMillion;
            bool ProcessedCustomer;
            Console.WriteLine(Age);
        }
    }
}