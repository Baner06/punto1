using System;

namespace cesharepruebauno
{
    class Program
    {
        static void Main(string[] args)
        {
            int pimeraNota = 0;
            int SegundaNota = 0;
            int terceraNota = 0;
            string valor = "";
            int promedio = 0;

            Console.WriteLine("introduce nota #1");
            valor = Console.ReadLine();
            pimeraNota = Convert.ToInt32(valor);
            pimeraNota = (int)(pimeraNota * 0.3);

            Console.WriteLine("introduce nota #2");
            valor = Console.ReadLine();
            SegundaNota = Convert.ToInt32(valor);
            SegundaNota = (int)(SegundaNota * 0.3);

            Console.WriteLine("introduce nota #3");
            valor = Console.ReadLine();
            terceraNota = Convert.ToInt32(valor);
            terceraNota = (int)(terceraNota * 0.4);

            promedio = (pimeraNota + SegundaNota + terceraNota);

            if (promedio <= 29)
                Console.WriteLine("el estudiante reporvo la materia");
            else if (promedio >= 51)
                Console.WriteLine("error de datos ingresados");
            else
                Console.WriteLine("el estudiante aprovo la materia");
        

        }
    }
}
