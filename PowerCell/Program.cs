using System;
using System.Collections.Concurrent;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Security.Authentication;

namespace PowerCell
{
    public class Program
    {
        public class Cell
        {
            private float charge;
            readonly string Name;
            public static float Charge
            {
                get
                {
                    return Charge;
                }
                set
                {
                    Charge = Charge;
                    if (Charge > 200)
                    {
                        Charge = 200;
                    }
                    else if (Charge < 0)
                    {
                        Charge = 0;
                    }
                }
            }
            
            readonly int Level = 1 + Convert.ToInt32(Charge) / 40;

            public float Consume(float amount)
            {
                return Charge -= amount;
            }
            
            public float Restore()
            {
                return Charge = 200;
            }

            public Cell(string name)
            {
                Name = name;
                charge = 200;
                Charge = charge;
            }

            public override string ToString()
            {
                return $"[{Name}] Level {Level}:  {Charge:F0}/200";
            }
        }

        // Argumentos:
        // args[0]: Nome da célula
        // args[1]: Número de consumos
        // args[2]: Quantidade de energia a consumir por operação
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            string name = args[0];
            int n = int.Parse(args[1]);
            float amount = float.Parse(args[2]);

            // Cria uma Nova Célula com o Nome Fornecido
            Cell c = new Cell(name);

            // Mostra o Estado Inicial da Célula
            Console.WriteLine(c);

            // Consome a Célula n Vezes
            for (int i = 0; i < n; i++) c.Consume(amount);

            // Mostra o Estado Após os Consumos
            Console.WriteLine(c);

            // Restaura a Célula e Mostra o Estado Final
            c.Restore();
            Console.WriteLine(c);

            // Este programa mostra o seguinte no ecrã (exemplo: Apollo 3 60):
            //
            // [Apollo] Level 6: 200/200
            // [Apollo] Level 1: 20/200
            // [Apollo] Level 6: 200/200
        }
    }
}