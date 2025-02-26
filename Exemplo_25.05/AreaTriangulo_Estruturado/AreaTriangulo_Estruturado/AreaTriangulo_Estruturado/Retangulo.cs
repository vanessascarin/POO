using System;

namespace AreaTriangulo_Estruturado
{
    class Retangulo
    {
        public double A;
        public double B;

        public double AreaRetangulo()
        {
            return A * B;
        }
        public double SemiPerimetro()
        {
            return (A + B) / 2;
        }
    }
}
