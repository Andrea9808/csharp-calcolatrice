namespace csharp_calcolatrice
{

    //Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale?
    //Il polimorfismo = ovvero un metodo può ridefinire i vari parametri ereditati dalla superclasse per cambiarne logica e riadattarli al contesto.

    internal static class CalcoliHelper
    {

        //SOMMA INT E DOUBLE
        public static int Somma(int numero_uno , int numero_due)
        {
            return numero_uno + numero_due;
        }

        public static double Somma(double numero_uno, double numero_due)
        {
            return numero_uno + numero_due;
        }

        //DIFFERENZA INT E DOUBLE
        public static int Differenza(int numero_uno, int numero_due)
        {
            return numero_uno - numero_due;
        }

        public static double Differenza(double numero_uno, double numero_due)
        {
            return numero_uno - numero_due;
        }

        //MOLTIPLICAZIONE INT E DOUBLE
        public static int Moltiplicazione(int numero_uno, int numero_due)
        {
            return numero_uno * numero_due;
        }

        public static double Moltiplicazione(double numero_uno, double numero_due)
        {
            return numero_uno * numero_due;
        }

        //VALORE INT E DOUBLE
        public static int ValoreAssoluto(int numero_uno, int numero_due)
        {
            if (numero_uno >= 0) 
            {
                return numero_uno;
            }
            else
            {
                return -numero_due;
            }
        }

        public static double ValoreAssoluto(double numero_uno, double numero_due)
        {
            if (numero_uno >= 0)
            {
                return numero_uno;
            }
            else
            {
                return -numero_due;
            }
        }

        //MINIMO INT E DOUBLE
        public static int Minimo(int numero_uno, int numero_due)
        {
            if (numero_uno < numero_due)
            {
                return numero_uno;
            }
            else
            {
                return numero_due;
            }
        }

        public static double Minimo(double numero_uno, double numero_due)
        {
            if (numero_uno < numero_due)
            {
                return numero_uno;
            }
            else
            {
                return numero_due;
            }
        }


        //MASSIMO INT E DOUBLE
        public static int Massimo(int numero_uno, int numero_due)
        {
            if (numero_uno > numero_due)
            {
                return numero_uno;
            }
            else
            {
                return numero_due;
            }
        }

        public static double Massimo(double numero_uno, double numero_due)
        {
            if (numero_uno > numero_due)
            {
                return numero_uno;
            }
            else
            {
                return numero_due;
            }
        }


        //BONUS
        public static int Potenza(int _base, int esponente)
        {
            if (esponente == 0)
            {
                // tutti i numero elevato alla potenza 0 è 1, ritorneranno 1
                return 1;
            }
            else if (esponente < 0)
            {
                // se l'esponente è negativo, invertiamo la base e cambiamo il segno dell'esponente
                _base = 1 / _base;
                esponente = -esponente;
            }

            int risultato = 1;
            for (int i = 0; i < esponente; i++)
            {
                risultato *= _base;
                if (risultato == 0)
                {
                    // se il risultato è 0, uscirà comunque 1
                    return 1;
                }
            }
            return risultato;
        }
    }
}
