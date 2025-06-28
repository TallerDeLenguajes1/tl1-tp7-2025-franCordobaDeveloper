namespace EspacioCalculadora
{
    class Calculadora
    {
        private double dato;

        public double Resultado
        {
            get { return dato; }
        }

        void Sumar(double termino)
        {
            dato += termino;
        }

        void Restar(double termino)
        {
            dato -= termino;
        }

        void Multiplicar(double termino)
        {
            dato *= termino;
        }
        void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato /= termino;
            }

            Console.WriteLine("Error no se puede divir en 0");
        }

        void Limpiar()
        {
            dato = 0;
        }
    }
}