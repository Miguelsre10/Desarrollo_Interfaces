using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ6_LISTAS
{
    internal class Program
    {
        static List<Card> ListCard = new List<Card>();
        static void Main(string[] args)
        {
            //Creamos un cromo y lo añadimos a la lista
            Card card1 = new Card(101, "Messi", Card.CategoryCard.Gold);
            ListCard.Add(card1);
            ListCard.Add(new Card(102, "Ronaldo", Card.CategoryCard.Silver));

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            CheckListCard();

            //Vamos a realizar otras operaciones
            List<Card> AuxList = new List<Card>()
            {
                new Card(103, "Ferran", Card.CategoryCard.Silver),
                new Card(104, "Neymar", Card.CategoryCard.Silver),
            };

            ListCard.Remove(card1);
            
            ListCard.AddRange(AuxList);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            CheckListCard();
            Console.ResetColor();

        }

        private static void CheckListCard()
        {
            foreach (Card card in ListCard)
            {
                Console.WriteLine($"Numero: {card.NumberCard}, Nombre: {card.NameCard}, Categoria: {card.MyCategoryCard}");
            }
        }
    }
}
