using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plemiona
{
    /// <summary>
    /// Klasa do zarządzania zasobami surowców
    /// </summary>
    class StockMenager
    {/// <summary>
    /// Kkonstruktor pobierający tablice z surowcami
    /// </summary>
    /// <param name="stocks">Tablica wszystkich surowców</param>
        public StockMenager(Stock[] stocks)
        {
            AllStocks = stocks;
        }
        public Stock[] AllStocks { get; set; } //Tablica przechowująca obiekty wszystkich zasobów

        /// <summary>
        /// Funkcja zprawdzająca czy jest wystarczająca ilość surowców do rozbudowy
        /// </summary>
        public void SetButtonVisibility()
        {
            int[] ownedStock = new int[4]; //tablica na ilość niezbędnych do budowy surowców: glina, żelazo, drewno i zasoby ludzkie
            ownedStock[0] = AllStocks[(int)NameStock.People].GetValue(); //Pobranie wartości ludzi
            ownedStock[1] = AllStocks[(int)NameStock.Iron].GetValue(); //Pobranie wartości żelaza
            ownedStock[2] = AllStocks[(int)NameStock.Clay].GetValue(); //Pobranie wartości gliny
            ownedStock[3] = AllStocks[(int)NameStock.Wood].GetValue(); //Pobranie wartości drewna

            foreach (Stock stock in AllStocks) //Sprawdzenie każdego z zasobów
            {
                int level = stock.GetLevel(); //Pobranie aktualnego poziomu rozbudowy
                bool isEnought = true; //zmienna przechowująca informację czy ilość surowcó wystarczy do rozbudowy
                foreach (int stockValue in ownedStock) //Iteracja po wszystkic surowcach do rozbudowy
                {
                    if((level * 3)> stockValue) //3*level to koszt rozbudowy
                    {
                        isEnought = false; //jesli zasobow jest za mało ustawiana jest zmienna na false
                    }
                }
                if(isEnought == true) //sprawdzenie czy brak któregoś zasobu nie zmienił zmiennej na false
                {
                    stock.ShowButton(); //pokazanie przycisku rozbudowy
                }
                else
                {
                    stock.HideButton(); //ukrycie przyciski rozbudowy
                }
            }
        }
        /// <summary>
        /// Metoda aktualizująca stan wszytskich surowców
        /// </summary>
        public void TakeStock()
        {
            foreach (Stock stock in AllStocks) //pobranie surowca dla każdego z zasobów
            {
                stock.TakeStocks();
            }
        }
        /// <summary>
        /// Metoda do rozbudowy jedengo z zasobów
        /// </summary>
        /// <param name="name">Nazwa reobudowywanego surowca</param>
        public void Develop(NameStock name)
        {
            int level = AllStocks[(int)name].GetLevel(); //pobranie wartości aktualnego poziomu
            int stockValueToReduce = level * 3; //ilość każdego rodzaju zasobów wymaganych do rozbudowy
            AllStocks[(int)NameStock.People].ReduceValue(stockValueToReduce); //pobranie zasobów ludzkich do rozbudowy
            AllStocks[(int)NameStock.Iron].ReduceValue(stockValueToReduce); //pobranie żelaza do rozbudowy
            AllStocks[(int)NameStock.Clay].ReduceValue(stockValueToReduce); //pobranie gliny do rozbudowy
            AllStocks[(int)NameStock.Wood].ReduceValue(stockValueToReduce); //pobranie drewna do rozbudowy
            AllStocks[(int)name].IncreaseLevel(); //zwiększenie pozomu i prędkości produkcji
            SetButtonVisibility();
        }
        /// <summary>
        /// Metoda do restartu zasobów
        /// </summary>
        public void Restart()
        {
            foreach (Stock stock in AllStocks)
            {
                stock.Restart(); //wywołanie funkcji resetującej element
            }
        }
    }
}
