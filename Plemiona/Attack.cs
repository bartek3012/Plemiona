using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plemiona
{
    /// <summary>
    /// Klasa do obsługi zadrzenia ataku
    /// </summary>
    class Attack
    {
        /// <summary>
        /// Pobranie grafiki z mieczami i etykiety z ilością wojska
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="armyLabel"></param>
        public Attack(PictureBox pictureBox, Label armyLabel)
        {
            attactPicture = pictureBox;
            armyValueLabel = armyLabel;
            step = 0; //początkowo ilość pokonanych kroków do wioski wynosi 0
        }
        private PictureBox attactPicture; //zbliżający się do wioski obrazek
        private Label armyValueLabel; //atykieta z  ilością wojska
        private Random random = new Random(); //obiekt do generowania liczb lodowych
        private int step; //zmienna pokonanych kroków do wioski
        /// <summary>
        /// Prowdopodobieństwo ataku to 1:20, funkcja losuje czy nastąpi atak
        /// </summary>
        /// <returns></returns>
        public bool IsAttack()
        {
            if (random.Next(1, 20) == 1)//jeśli wylosowano 1 wojska wroga zaczynają zbliżać się do wioski
            {
                attactPicture.Visible = true; //ustawieni widoczności przycisku
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Ruch wojska atakujących, a w przypadku dotarcia do wioski rozpoczęcia ataku. Zwracana jest wartość false w przypadku porażki
        /// </summary>
        public bool AttackMove()
        {
            if(step < 10) //jeśli wojska jeszcze idą (mają łącznie 10 kroków do celu)
            {
            step++; //zwięsz licznik kroków
            attactPicture.Location = new System.Drawing.Point(attactPicture.Location.X, attactPicture.Location.Y-12); //przesuń grafikę
                return true;
            }
            else //jeśli doszły do wioski
            {
                step = 0; //serowanie kroku
                attactPicture.Location = new System.Drawing.Point(attactPicture.Location.X, attactPicture.Location.Y + 120); //powrót grafiki do pozycji początkowej
                attactPicture.Visible = false; //ustawienie początkowej widzialnośc grafiki
                int opponentArmyValue = random.Next(1, 100); //losowanie ilości wojsk przeciwnika
                int yourArmyValue; //zmienna do ilości wojsk gracza
                Int32.TryParse(armyValueLabel.Text, out yourArmyValue); //pobranie ilości wojsk gracza
                AttactForm attactForm = new AttactForm(yourArmyValue, opponentArmyValue); //stworzenie okna walki
                attactForm.Show(); //pokazanie okna walki
                if(opponentArmyValue>yourArmyValue) //jeśli gracz przegrał
                {
                    return false; //zwrócenie przegranej
                }
                else
                {
                    yourArmyValue -= opponentArmyValue; //aktualizacja stanu wojska
                    armyValueLabel.Text = yourArmyValue.ToString(); //aktualizacja stanu wojska (etykieta)
                    return true; //zwrócenie wygranej
                }
            }
        }
    }
}
