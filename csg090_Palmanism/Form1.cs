using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace csg090_Palmanism
{
    public partial class Form1 : Form
    {
        private Card[] playingCards;
        private Player player;
        private int gameSec;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createCards(ref playingCards);
            player = new csg090_Palmanism.Player();

            SuspendLayout();
            const int offsetX = 30, offsetY = 50;

            for(int i = 0; i < playingCards.Length; i++)
            {
                playingCards[i].Name = "card" + i;
                int sizeW = playingCards[i].Size.Width;
                int sizeH = playingCards[i].Size.Height;
                playingCards[i].Location =
                    new Point(offsetX + i % 8 * sizeW, offsetY + i / 8 * sizeH);

                playingCards[i].Click += new EventHandler(cardButtons_Click);
  
            }

            Controls.AddRange(playingCards);
            ResumeLayout(false);

            labelGuidance.Text = "スタートボタンをクリックしてゲームを開始してください。";


        }

        private void createCards(ref Card[] cards)
        {
            string[] picture = {
                "○", "●", "△", "▲", "□", "■", "◇", "◆", "☆", "★", "※", "×"
            };

            cards = new Card[picture.Length * 2];
            for (int i = 0, j = 0; i < cards.Length; i += 2, j++)
            {
                cards[i] = new Card(picture[j]);
                cards[i + 1] = new Card(picture[j]);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            shuffleCard(playingCards);

            foreach (Card c in playingCards)
            {
                c.Close();                 
            }

            buttonStart.Enabled = false;    
            gameSec = 0;
            timer1.Start();

            labelGuidance.Text = "クリックしてカードをめくってください。";
        }

        private void shuffleCard(Card[] cards)
        {
            Random r = new Random();

            int n = cards.Length - 1;
            while (n > 0)
            {
                int w = r.Next(0, n);
                string s = cards[n].Picture;
                cards[n].Picture = cards[w].Picture;
                cards[w].Picture = s;
                n--;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameSec++;
            labelSec.Text = gameSec + "秒経過";
        }

        private void cardButtons_Click(object sender, EventArgs e)
        {

            if (player.OpenCounter == 0)
            {
                
                int b1 = player.PreviousOpenCardIndex1;
                int b2 = player.PreviousOpenCardIndex2;
                if (b1 != -1 && b2 != -1 && matchCard(playingCards, b1, b2) == false)
                {
                    playingCards[b1].Close();
                    playingCards[b2].Close();
                }
               
                int n1 = int.Parse(((Button)sender).Name.Substring(4));
              
                playingCards[n1].Open();
                player.PresentOpenCardIndex1 = n1;

                labelGuidance.Text = "もう一枚めくってください。";
            }
           
            else if (player.OpenCounter == 1)
            {
                
                int n2 = int.Parse(((Button)sender).Name.Substring(4));
               
                playingCards[n2].Open();
                player.PresentOpenCardIndex2 = n2;
               
                if (matchCard(playingCards, player.PresentOpenCardIndex1,
                            player.PresentOpenCardIndex2) == true)
                    labelGuidance.Text =
                            "カードは一致しました。次のカードをめくってください。";
                else
                    labelGuidance.Text =
                            "カードは不一致です。次のカードをめくってください。";

                
                player.Reset();
             
                if (allOpenCard(playingCards))
                {
                    labelGuidance.Text = "全部のカードが一致しました。お疲れ様でした。";
                    timer1.Stop();
                    buttonStart.Enabled = true; 
                }
            }
        }

        private bool allOpenCard(Card[] cards)
        {
            foreach (Card c in cards)
            {
                if (c.State == false)
                    return false;
            }
            return true;
        }

        private bool matchCard(Card[] cards, int index1, int index2)
        {
            if (index1 < 0 || index1 >= cards.Length ||
                index2 < 0 || index2 >= cards.Length)
                return false;

            if (cards[index1].Picture == cards[index2].Picture)
                return true;
            else
                return false;
        }
    }
}
