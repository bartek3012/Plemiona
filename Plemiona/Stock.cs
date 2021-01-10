using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plemiona
{
    /// <summary>
    /// Klasa reprezentująca typy zasobów (ludność, punky chwały, wojsko, glina, drewno i żelazo
    /// </summary>
    class Stock
    {
        /// <summary>
        /// Przypisanie wartości zmiennych
        /// </summary>
        /// <param name="value">Ilośc surowca</param>
        /// <param name="speed">Prędkośc produkcji</param>
        /// <param name="level">Poziom rozbudowy</param>
        /// <param name="actionButton">Przycisk rozbudowy</param>
        public Stock(Label value, Label speed, Label level, Button actionButton)
        {
            labelValue = value;
            labelSpeed = speed;
            labelLevel = level;
            buttonBuild = actionButton;
        }
        //Etykieta przechowująca wartość zasobu
        private Label labelValue;
        //Etykieta przechowująca prędkośc produkcji zasobu
        private Label labelSpeed;
        //Etykieta przechowująca ilość punktów chwały
        private Label labelLevel;
        //Przycisk rozbudowania zasobu
        private Button buttonBuild;

        /// <summary>
        /// Zwiększenie poziomu i prędkości produkcji
        /// </summary>
        public void IncreaseLevel()
        {
            int level;//zmienna na przechowanie poziomu
            Int32.TryParse(labelLevel.Text,out level);//pobranie poziomu
            level++; //zwiększenie wartości poziomu
            labelLevel.Text = level.ToString();//aktualizacja poziomu
            labelSpeed.Text = level.ToString();//aktualizacja prędkości produkcji
        }
        /// <summary>
        /// Aktualizacja ilości zasobów
        /// </summary>
        public void TakeStocks()
        {
            int stockToTake, ownedStock; //Zmienna przechowująca ilość zasbów do pobrania i aktualną ilość surowca
            Int32.TryParse(labelSpeed.Text,out stockToTake); //Pobranie wartości dodawanego surowca
            Int32.TryParse(labelValue.Text, out ownedStock); //Pobranie aktualnej iloścu surowca
            ownedStock += stockToTake; //sumowanie posiadanej wartości i pobieranej
            labelValue.Text = ownedStock.ToString(); //Aktualizacja etykiety z wartością surowca
        }
        /// <summary>
        /// Ustawienie przycisku jako widzialnego
        /// </summary>
        public void ShowButton()
        {
            buttonBuild.Visible = true; //Ustawienie przycisku na widoczny
        }
        /// <summary>
        /// Ukrycie przycisku
        /// </summary>
        public void HideButton()
        {
            buttonBuild.Visible = false;//Ukrycie przycisku
        }
        /// <summary>
        /// Zwraca ilość posiadanych zasobów surowca
        /// </summary>
        /// <returns></returns>
        public int GetValue()
        {
            int ownedStock; //Zmienna do ilości surowców
            Int32.TryParse(labelValue.Text, out ownedStock); //Pobranie aktualnej iloścu surowca
            return ownedStock; //Zwrócenie ilości surowców
        }
        /// <summary>
        /// Funckja zmniejszająca o podaną ilość zasoby surowca
        /// </summary>
        /// <param name="reduction">Ilość odejmowanych surowców</param>
        public void ReduceValue(int reduction)
        {
            int ownedStock = GetValue(); //pobranie aktualnej wartości
            ownedStock -= reduction; //redukcja zasobów
            labelValue.Text = ownedStock.ToString(); //wyświetlenie aktualnej wartości

        }
        /// <summary>
        /// Rastart danego surowca
        /// </summary>
        internal void Restart()
        {
            labelValue.Text = "0";
            labelSpeed.Text = "1";
            labelLevel.Text = "1";
        }

        /// <summary>
        /// Zwraca aktualny poziom rozbudowy
        /// </summary>
        /// <returns></returns>
        public int GetLevel()
        {
            int level; //Zmienna do przechowywania poziomu
            Int32.TryParse(labelLevel.Text, out level); //Pobranie aktualnej waertości poziomu
            return level; //Zwrócenie aktualnego poziomu
        }


    }
}
