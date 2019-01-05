using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 60); // Taille de la console 150 x 60 pixels/ caractères
            Console.BackgroundColor = ConsoleColor.White; // Le fond de la console est blanc
            Console.Clear();

            string[] menus = {"mode de jeu","qui commence","niveaux ordi"};
            int[] status = new int[menus.Length]; // 0: closed, 1: current_closed, 2: current_open, 3: selected, 4: locked
            int[] selection = new int[menus.Length];
            string[][] sousMenus = new string[menus.Length][];
            bool select = false;
            
            status[0] = 1;
            status[1] = 0;
            status[2] = 4;

            while (!select)
            {

                AfficherMenu(menus, status);
                ConsoleKeyInfo bouton = Console.ReadKey();
            }
        }

        static void AfficherMenu(string[] menus, int[] status)
        {
            ConsoleColor[] couleurs = new ConsoleColor[status.Length]; 
            for(int i =0; i < status.Length; i++)
            {
                switch (status[i])
                {
                    case 0:
                        couleurs[i] = ConsoleColor.White;
                        break;
                    case 1:
                        couleurs[i] = ConsoleColor.Red;
                        break;
                    case 2:
                        couleurs[i] = ConsoleColor.DarkRed;
                        break;
                    case 3:
                        couleurs[i] = ConsoleColor.DarkGray;
                        break;
                    case 4:
                        couleurs[i] = ConsoleColor.Gray;
                        break;
                }
            }
            AfficherTextRegulier(menus, couleurs, 25);
        }

        static void AfficherTextRegulier(string[] messages, ConsoleColor[] couleurs, int hauteur)
        {
            int nombre = messages.Length + 1;
            int width = Console.WindowWidth;
            int position = 0;
            Console.ForegroundColor = ConsoleColor.Black;
            foreach (string message in messages)
            {
                position++;
                Console.BackgroundColor = couleurs[position-1];
                int debut = ((width - message.Length) / nombre) * position;
                Console.SetCursorPosition(debut, hauteur);
                Console.Write(message);
            }
        }
    }
}
