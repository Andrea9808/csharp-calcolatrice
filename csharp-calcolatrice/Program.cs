namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // SOMMA INTERO
                Console.WriteLine();
                Console.WriteLine("SOMMA INTERO");
                Console.WriteLine("Inserisci il primo numero intero: ");
                int numero_uno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero intero: ");
                int numero_due = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"La somma tra {numero_uno} e {numero_due} è : {CalcoliHelper.Somma(numero_uno, numero_due)}");
            }


            {
                // SOMMA INTERO
                Console.WriteLine();
                Console.WriteLine("SOMMA DOUBLE");
                Console.WriteLine("Inserisci il primo numero double: ");
                double numero_uno = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero double: ");
                double numero_due = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"La somma tra {numero_uno} e {numero_due} è : {CalcoliHelper.Somma(numero_uno, numero_due)}");

            }

            {
                // DIFFERENZA INTERO
                Console.WriteLine();
                Console.WriteLine("DIFFERENZA INTERO");
                Console.WriteLine("Inserisci il primo numero intero: ");
                int numero_uno_int = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero intero: ");
                int numero_due_int = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"La differenza tra {numero_uno_int} e {numero_due_int} è: {CalcoliHelper.Differenza(numero_uno_int, numero_due_int)}");
            }

            {
                // DIFFERENZA DOUBLE
                Console.WriteLine();
                Console.WriteLine("DIFFERENZA DOUBLE");
                Console.WriteLine("Inserisci il primo numero double: ");
                double numero_uno_double = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero double: ");
                double numero_due_double = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"La differenza tra {numero_uno_double} e {numero_due_double} è: {CalcoliHelper.Differenza(numero_uno_double, numero_due_double)}");
            }

            {
                // MOLTIPLICAZIONE INTERO
                Console.WriteLine();
                Console.WriteLine("MOLTIPLICAZIONE INTERO");
                Console.WriteLine("Inserisci il primo numero intero: ");
                int numero_uno_int = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero intero: ");
                int numero_due_int = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Il risultato della moltiplicazione tra {numero_uno_int} e {numero_due_int} è: {CalcoliHelper.Moltiplicazione(numero_uno_int, numero_due_int)}");
            }

            {
                // MOLTIPLICAZIONE DOUBLE
                Console.WriteLine();
                Console.WriteLine("MOLTIPLICAZIONE DOUBLE");
                Console.WriteLine("Inserisci il primo numero double: ");
                double numero_uno_double = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero double: ");
                double numero_due_double = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Il risultato della moltiplicazione tra {numero_uno_double} e {numero_due_double} è: {CalcoliHelper.Moltiplicazione(numero_uno_double, numero_due_double)}");
            }

            {
                // VALORE ASSOLUTO INTERO
                Console.WriteLine();
                Console.WriteLine("VALORE ASSOLUTO INTERO");
                Console.WriteLine("Inserisci il primo numero intero: ");
                int numero_uno_int = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero intero: ");
                int numero_due_int = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Il valore assoluto del maggiore tra {numero_uno_int} e {numero_due_int} è: {CalcoliHelper.ValoreAssoluto(numero_uno_int, numero_due_int)}");
            }

            {
                // VALORE ASSOLUTO DOUBLE
                Console.WriteLine();
                Console.WriteLine("VALORE ASSOLUTO DOUBLE");
                Console.WriteLine("Inserisci il primo numero double: ");
                double numero_uno_double = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero double: ");
                double numero_due_double = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Il valore assoluto del maggiore tra {numero_uno_double} e {numero_due_double} è: {CalcoliHelper.ValoreAssoluto(numero_uno_double, numero_due_double)}");
            }

            {
                // MINIMO INTERO
                Console.WriteLine();
                Console.WriteLine("MINIMO INTERO");
                Console.WriteLine("Inserisci il primo numero intero: ");
                int numero_uno_int = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero intero: ");
                int numero_due_int = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Il minimo tra {numero_uno_int} e {numero_due_int} è: {CalcoliHelper.Minimo(numero_uno_int, numero_due_int)}");
            }

            {
                // MINIMO DOUBLE
                Console.WriteLine();
                Console.WriteLine("MINIMO DOUBLE");
                Console.WriteLine("Inserisci il primo numero double: ");
                double numero_uno_double = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero double: ");
                double numero_due_double = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Il minimo tra {numero_uno_double} e {numero_due_double} è: {CalcoliHelper.Minimo(numero_uno_double, numero_due_double)}");
            }

            {
                // MASSIMO INTERO
                Console.WriteLine();
                Console.WriteLine("MASSIMO INTERO");
                Console.WriteLine("Inserisci il primo numero intero: ");
                int numero_uno_int = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero intero: ");
                int numero_due_int = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Il massimo tra {numero_uno_int} e {numero_due_int} è: {CalcoliHelper.Massimo(numero_uno_int, numero_due_int)}");
            }

            {
                // MASSIMO DOUBLE
                Console.WriteLine();
                Console.WriteLine("MASSIMO DOUBLE");
                Console.WriteLine("Inserisci il primo numero double: ");
                double numero_uno_double = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero double: ");
                double numero_due_double = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Il massimo tra {numero_uno_double} e {numero_due_double} è: {CalcoliHelper.Massimo(numero_uno_double, numero_due_double)}");
            }

        }
    }
}
