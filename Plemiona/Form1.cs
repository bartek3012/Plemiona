using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plemiona
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda wywyoływane po konstruktorze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Stock[] stocks = new Stock[(int)NameStock.Length];//tablica na zasoby 
            stocks[(int)NameStock.Point] = new Stock(labelPointValue, labelPointSpeed, labelPointLevelValue, buttonPoint); //utworzenie obiektu zasobów dla puntów chwały
            stocks[(int)NameStock.People] = new Stock(labelPeopleValue, labelPeopleSpeed, labelPeopleLevelValue, buttonPeople); //utworzenie obiektu zasobów dla ludzi
            stocks[(int)NameStock.Army] = new Stock(labelArmyValue, labelArmySpeed, labelArmyLevelValue, buttonArmy); //utworzenie obiektu zasobów dla puntów wojska
            stocks[(int)NameStock.Iron] = new Stock(labelIronValue, labelIronSpeed, labelIronLevelValue, buttonIron); //utworzenie obiektu zasobów dla puntów żelaza
            stocks[(int)NameStock.Clay] = new Stock(labelClayValue, labelClaySpeed, labelClayLevelValue, buttonClay); //utworzenie obiektu zasobów dla puntów gliny
            stocks[(int)NameStock.Wood] = new Stock(labelWoodValue, labelWoodSpeed, labelWoodLevelValue, buttonWood); //utworzenie obiektu zasobów dla puntów drewna
            stockMenager = new StockMenager(stocks); //inicjalizacja klasy zarządzającej surowcami
            attack = new Attack(pictureBoxAttack, labelArmyValue);
            pictureBoxAttack.Visible = false;
            timerCounter.Start(); //start timera
        }
        private StockMenager stockMenager; //obiekt klasy zarządzajacej surowcami
        Attack attack;
        /// <summary>
        /// Funkcja obsługująca wywołanie zegarowe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            stockMenager.SetButtonVisibility(); //funckja sprawdza czy surowców na rozbudowę danego zasobu i ustawia widoczność przycisku do rozbudowy
            stockMenager.TakeStock(); //funckja pobierające należna surowce na podstawie prędkości produkcji
            if(pictureBoxAttack.Visible == false) //Jeśli wróg teraz nie atakuje
            {
                attack.IsAttack(); //Losuj czy ztakuje
            }
            else
            {
                if(attack.AttackMove() == false) //Czy przegrał bitwe
                {
                    stockMenager.Restart(); //Obniż poniomy rozbudowy i zasobów do zera
                }
            }
            if(stockMenager.AllStocks[(int)NameStock.Point].GetValue()>=500) //Jeśli gracz ma min 500 pkt wygrywa grę
            {
                timerCounter.Stop(); //Zatrzymanie zegara
                var result = MessageBox.Show("Gratulacje! Wygrałeś grę! Chcesz rozpocząć ponownie czy wyjść z gry?", "Gratulacje", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //Wywołanie text boxa
                if (result == DialogResult.Yes)
                {
                    timerCounter.Start(); //wznowienie zegara
                    stockMenager.Restart(); //restart gry
                }
                else
                {
                    Application.Exit(); //Wyjście z aplikacji
                }
            }

        }
        /// <summary>
        /// Zdarzenie kliknięcia w przycisk i rozbudowy danego zasobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuild_Click(object sender, EventArgs e)
        {
            if((sender as Button) == buttonPoint) //sprawdzenie czy przycisk pasuje do danych zasobów
            {
                stockMenager.Develop(NameStock.Point); //wywołanie metody rozbudowującej poziom puntków
            }
            else if ((sender as Button) == buttonPeople) //sprawdzenie czy przycisk pasuje do danych zasobów
            {
                stockMenager.Develop(NameStock.People); //wywołanie metody rozbudowującej poziom zasobu ludzi
            }
            else if ((sender as Button) == buttonArmy) //sprawdzenie czy przycisk pasuje do danych zasobów
            {
                stockMenager.Develop(NameStock.Army); //wywołanie metody rozbudowującej poziom zasobu wojska
            }
            else if ((sender as Button) == buttonIron) //sprawdzenie czy przycisk pasuje do danych zasobów
            {
                stockMenager.Develop(NameStock.Iron); //wywołanie metody rozbudowującej poziom zasobu żelaza
            }
            else if ((sender as Button) == buttonWood) //sprawdzenie czy przycisk pasuje do danych zasobów
            {
                stockMenager.Develop(NameStock.Wood); //wywołanie metody rozbudowującej poziom zasobu drewna
            }
            else if ((sender as Button) == buttonClay) //sprawdzenie czy przycisk pasuje do danych zasobów
            {
                stockMenager.Develop(NameStock.Clay); //wywołanie metody rozbudowującej poziom zasobu gliny
            }
        }
    }
}
