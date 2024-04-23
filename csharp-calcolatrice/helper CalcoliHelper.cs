namespace csharp_calcolatrice
{
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
    }
}
