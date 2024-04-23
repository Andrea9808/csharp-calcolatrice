namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "";
            while (input != "esci")
            {
                Console.WriteLine("Scegli un'opzione");
                Console.WriteLine("1. SOMMA");
                Console.WriteLine("2. DIFFERENZA");
                Console.WriteLine("3. MOLTIPLICAZIONE");
                Console.WriteLine("4. VALORE ASSOLUTO");
                Console.WriteLine("5. MINIMO");
                Console.WriteLine("6. MASSIMO");
                Console.WriteLine("7. ELEVAMENTO A POTENZA");
                Console.WriteLine("esci. Esci dal programma");

                input = Console.ReadLine();

                if (input == "esci")
                {
                    Console.WriteLine("Ciao!");
                    break; 
                }
                else if (input == "1")
                {
                    // SOMMA INTERO
                    Console.WriteLine();
                    Console.WriteLine("SOMMA INTERO");
                    Console.WriteLine("Inserisci il primo numero intero: ");
                    int numero_uno_int = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo numero intero: ");
                    int numero_due_int = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"La somma tra {numero_uno_int} e {numero_due_int} è : {CalcoliHelper.Somma(numero_uno_int, numero_due_int)}");


                    // SOMMA DOUBLE
                    Console.WriteLine();
                    Console.WriteLine("SOMMA DOUBLE");
                    Console.WriteLine("Inserisci il primo numero double: ");
                    double numero_uno_double = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo numero double: ");
                    double numero_due_double = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"La somma tra {numero_uno_double} e {numero_due_double} è : {CalcoliHelper.Somma(numero_uno_double, numero_due_double)}");
                }
                else if (input == "2")
                {
                    // DIFFERENZA INTERO
                    Console.WriteLine();
                    Console.WriteLine("DIFFERENZA INTERO");
                    Console.WriteLine("Inserisci il primo numero intero: ");
                    int numero_uno_int = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo numero intero: ");
                    int numero_due_int = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"La differenza tra {numero_uno_int} e {numero_due_int} è: {CalcoliHelper.Differenza(numero_uno_int, numero_due_int)}");


                    // DIFFERENZA DOUBLE
                    Console.WriteLine();
                    Console.WriteLine("DIFFERENZA DOUBLE");
                    Console.WriteLine("Inserisci il primo numero double: ");
                    double numero_uno_double = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo numero double: ");
                    double numero_due_double = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"La differenza tra {numero_uno_double} e {numero_due_double} è: {CalcoliHelper.Differenza(numero_uno_double, numero_due_double)}");
                }
                else if (input == "3")
                {
                    // MOLTIPLICAZIONE INTERO
                    Console.WriteLine();
                    Console.WriteLine("MOLTIPLICAZIONE INTERO");
                    Console.WriteLine("Inserisci il primo numero intero: ");
                    int numero_uno_int = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo numero intero: ");
                    int numero_due_int = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Il risultato della moltiplicazione tra {numero_uno_int} e {numero_due_int} è: {CalcoliHelper.Moltiplicazione(numero_uno_int, numero_due_int)}");


                    // MOLTIPLICAZIONE DOUBLE
                    Console.WriteLine();
                    Console.WriteLine("MOLTIPLICAZIONE DOUBLE");
                    Console.WriteLine("Inserisci il primo numero double: ");
                    double numero_uno_double = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo numero double: ");
                    double numero_due_double = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Il risultato della moltiplicazione tra {numero_uno_double} e {numero_due_double} è: {CalcoliHelper.Moltiplicazione(numero_uno_double, numero_due_double)}");

                }
                else if (input == "4")
                {
                    // VALORE ASSOLUTO INTERO
                    Console.WriteLine();
                    Console.WriteLine("VALORE ASSOLUTO INTERO");
                    Console.WriteLine("Inserisci un numero intero: ");
                    int numero_int = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Il valore assoluto di {numero_int} è: {CalcoliHelper.ValoreAssoluto(numero_int)}");

                    // VALORE ASSOLUTO DOUBLE
                    Console.WriteLine();
                    Console.WriteLine("VALORE ASSOLUTO DOUBLE");
                    Console.WriteLine("Inserisci un numero double: ");
                    double numero_double = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Il valore assoluto di {numero_double} è: {CalcoliHelper.ValoreAssoluto(numero_double)}");

                }
                else if (input == "5")
                {

                    // MINIMO INTERO
                    Console.WriteLine();
                    Console.WriteLine("MINIMO INTERO");
                    Console.WriteLine("Inserisci il primo numero intero: ");
                    int numero_uno_int = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo numero intero: ");
                    int numero_due_int = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Il minimo tra {numero_uno_int} e {numero_due_int} è: {CalcoliHelper.Minimo(numero_uno_int, numero_due_int)}");


                    // MINIMO DOUBLE
                    Console.WriteLine();
                    Console.WriteLine("MINIMO DOUBLE");
                    Console.WriteLine("Inserisci il primo numero double: ");
                    double numero_uno_double = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo numero double: ");
                    double numero_due_double = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Il minimo tra {numero_uno_double} e {numero_due_double} è: {CalcoliHelper.Minimo(numero_uno_double, numero_due_double)}");

                }
                else if (input == "6")
                {
                    // MASSIMO INTERO
                    Console.WriteLine();
                    Console.WriteLine("MASSIMO INTERO");
                    Console.WriteLine("Inserisci il primo numero intero: ");
                    int numero_uno_int = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo numero intero: ");
                    int numero_due_int = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Il massimo tra {numero_uno_int} e {numero_due_int} è: {CalcoliHelper.Massimo(numero_uno_int, numero_due_int)}");

                    // MASSIMO DOUBLE
                    Console.WriteLine();
                    Console.WriteLine("MASSIMO DOUBLE");
                    Console.WriteLine("Inserisci il primo numero double: ");
                    double numero_uno_double = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo numero double: ");
                    double numero_due_double = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Il massimo tra {numero_uno_double} e {numero_due_double} è: {CalcoliHelper.Massimo(numero_uno_double, numero_due_double)}");

                }

                //BONUS
                else if (input == "7")
                {
                    // ELEVAMENTO A POTENZA
                    Console.WriteLine();
                    Console.WriteLine("ELEVAMENTO A POTENZA");
                    Console.WriteLine("Inserisci la base: ");
                    int _base = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inserisci l'esponente: ");
                    int esponente = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Il risultato dell'elevamento a potenza è: {CalcoliHelper.Potenza(_base, esponente)}");
                }
                else
                {
                    Console.WriteLine("Input non valido. Riprova.");
                }
            }
        }
    }
}
