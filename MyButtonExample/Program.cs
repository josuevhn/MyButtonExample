using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyButtonExample
{

    class Program
    {

        static void Main(string[] args)
        {

            MyButton button = new MyButton();

            button.ClickEvent += OnClick;

            string answer;

            while (true)
            {

                Console.WriteLine();

                Console.Write("Damos click al botón (si / no)? ");

                answer = Console.ReadLine();

                if (answer.ToUpper() == "SI")
                {

                    button.actionClick();

                    break;

                } // if
                else if (answer.ToUpper() == "NO")
                {

                    break;

                } // else if

            } // while

            Console.WriteLine();

            Console.WriteLine("Presione una tecla para salir!");

            Console.ReadKey();

        } // Main

        static public void OnClick(object source, EventArgs args)
        {

            Console.WriteLine();

            Console.WriteLine("Código a ejecutar cuando damos click...");

        } // OnClick

    } // Program

} // MyButtonExample