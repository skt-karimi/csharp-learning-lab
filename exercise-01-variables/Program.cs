namespace TEST_001_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //namn
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();


            //ålder 
            int ålder = 0;
            Console.WriteLine("Hur gammal är du?");
            while (!int.TryParse(Console.ReadLine(), out ålder) || ålder <= 0 || ålder > 120) 
            {
                Console.WriteLine("Ogiltigt värde! Ange en ålder mellan 1 och 120.");
            }

            // vikt
            double vikt = 0;
            Console.WriteLine ("Hur många kilogram väger du?");

            while(!double.TryParse(Console.ReadLine() , out vikt ) || vikt < 10 )
            {
                Console.WriteLine("Ogiltigt värde! Försök igen.");
            }
            //Försök igen
            Console.WriteLine($"Hej {namn}! Du är {ålder} år gammal och väger {vikt} kg.");

            if (vikt >= 50 && vikt <= 100)
            {
                Console.WriteLine("Din vikt är inom det normala intervallet.");
            }
            else
            {
                Console.WriteLine("Din vikt är utanför det normala intervallet.");
            }

                //Hej Ali! Du är 32 år gammal och väger 68.5 kg.
        }
    }
}
// ------------------------------------------------------
// Övning 1.2 – Användarinmatning och utskrift
// ------------------------------------------------------
// 1. Fråga användaren om deras namn (string namn)
// 2. Fråga efter ålder och kontrollera att det är ett giltigt heltal (1–120)
// 3. Fråga efter vikt i kilogram och kontrollera att det är ett giltigt tal (minst 10 kg)
// 4. Om något värde är ogiltigt, be användaren att försöka igen
// 5. Skriv ut ett meddelande med all information, t.ex.:
//    Hej Ali! Du är 32 år gammal och väger 68.5 kg.
// -------------------------------------------------------------
// Extra funktion: Kontrollera om vikten är "normal" eller ej
// -------------------------------------------------------------
// Lägg till en enkel if-sats efter att användaren har angett vikt:
//
// if (vikt >= 50 && vikt <= 100)
// {
//     Console.WriteLine("Din vikt är inom det normala intervallet.");
// }
// else
// {
//     Console.WriteLine("Din vikt är utanför det normala intervallet.");
// }
//
// -------------------------------------------------------------
// Du kan själv ändra värdena för vad som räknas som "normalt"
// beroende på hur du vill tolka det.
// ------------------------------------------------------------
