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

            string[] menus = {"mode de jeu","premier à jouer","",""};
            int[] statut = { 0, 0, 0, 0}; // 0: closed, 1: current_closed, 2: current_open, 3: selected, 4: locked
            string[][] sousMenus = new string[menus.Length][];
        }

        static void AfficherTextRegulier(string[] messages, ConsoleColor[] couleurs, int hauteur)
        {
            int nombre = messages.Length + 1;
            int width = Console.WindowWidth;
            int position = 0;
            foreach (string message in messages)
            {
                position++;
                Console.ForegroundColor = couleurs[position - 1];
                int debut = ((width - message.Length) / nombre) * position;
                Console.SetCursorPosition(debut, hauteur);
                Console.Write(message);
            }
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
