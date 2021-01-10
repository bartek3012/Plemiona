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
    public partial class AttactForm : Form
    {
        /// <summary>
        /// Okno informujące o przebiegu walki
        /// </summary>
        /// <param name="player">Ilość wojsk gracza</param>
        /// <param name="opponent">Ilosć wojsk przeciwnika</param>
        public AttactForm(int player, int opponent)
        {
            InitializeComponent();
            labelYourArmyValue.Text = player.ToString();//przypisanie ilosci wojsk do etykiety
            labelOpponentArmyValue.Text = opponent.ToString();//przypisanie ilosci wojsk do etykiety
            if (opponent>player)//Warunek jeśli gracz rzegrał
            {
                labelWin.Text = "Przegrana"; //Zmiana napisu
                labelWin.ForeColor = Color.DarkRed; //Zminan czcionka
            }
        }

    }
}
