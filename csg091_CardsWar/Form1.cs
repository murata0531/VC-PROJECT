using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace csg091_CardsWar
{
    // ゲームの進行を制御する
    public partial class Form1 : Form
    {
        private Card[] wholeCards;          
        private Card[] playerCards;         
        private Card[] compCards;       
        private Player player;              
        private Computer comp;          

        public Form1()
        {
            InitializeComponent();
        }

        // フォームロードのイベントハンドラ
        private void Form1_Load(object sender, EventArgs e)
        {
            // カードの生成
            createCards(ref wholeCards);

            // カードをシャッフルする
            shuffleCard(wholeCards);

            // カードを分ける
            playerCards = new Card[wholeCards.Length / 2];
            compCards = new Card[wholeCards.Length / 2];
            Array.Copy(wholeCards, playerCards, playerCards.Length);
            Array.Copy(wholeCards, playerCards.Length, compCards, 0, compCards.Length);

            // プレイヤーの生成
            player = new Player();
            comp = new Computer(compCards.Length);

            // コンピュータのカードをFormに並べる
            SuspendLayout();
            int offsetX = 130, offsetY = 30;
            for (int i = 0; i < compCards.Length; i++)
            {
                // カード（ボタン）のプロパティを設定する
                compCards[i].Name = "compCards" + i.ToString();
                int sizeW = compCards[i].Size.Width;
                compCards[i].Location = new Point(offsetX + i * sizeW, offsetY);
            }
            Controls.AddRange(compCards);

            // ユーザのカードをFormに並べる
            offsetY = 240;
            for (int i = 0; i < playerCards.Length; i++)
            {
                // カード（ボタン）のプロパティを設定する
                playerCards[i].Name = "playerCards" + i.ToString();
                int sizeW = playerCards[i].Size.Width;
                playerCards[i].Location = new Point(offsetX + i * sizeW, offsetY);
                // ユーザのカードだけイベントハンドラに関連付け
                playerCards[i].Click += new EventHandler(cardButtons_Click);
                playerCards[i].Enabled = true;
            }
            Controls.AddRange(playerCards);
            ResumeLayout(false);

            labelGuidance.Text = "カードを選んでください。";
            buttonRestart.Enabled = false;
        }

        // カードButtonのクリックイベントハンドラ
        private void cardButtons_Click(object sender, EventArgs e)
        {
            // カードの添字を取得
            int n1 = int.Parse(((Button)sender).Name.Substring(11));

            // 前のカードの表示をグレイにする
            player.Reset();
            comp.Reset();
            if (player.PrevCardIndex != -1)
                playerCards[player.PrevCardIndex].BackColor = Color.LightGray;
            if (comp.PrevCardIndex != -1)
                compCards[comp.PrevCardIndex].BackColor = Color.LightGray;

            // カードを開く
            player.CurrCardIndex = n1;
            playerCards[n1].Open();

            // コンピュータがカードを引く
            int n2 = comp.DrawCard();
            compCards[n2].Open();

            // 勝敗を判定する
            int score = judge(playerCards, n1, compCards, n2);
            if (score == 0)
            {
                labelGuidance.Text = "コンピュータの勝ちです。次のカードを選んでください。";
                comp.Score += 2;
            }
            else if (score == 1)
            {
                labelGuidance.Text = "引き分けです。次のカードを選んでください。";
                player.Score += score;
                comp.Score += score;
            }
            else
            {
                labelGuidance.Text = "あなたの勝ちです。次のカードを選んでください。";
                player.Score += score;
            }

            // 得点を更新する
            labelCompScore.Text = "得点 ： " + comp.Score;
            labelPlayerScore.Text = "得点 ： " + player.Score;

            // 全部開いたか
            if (areAllOpen(playerCards) == true)
            {
                if (player.Score == comp.Score)
                    labelGuidance.Text = "引き分けです。お疲れ様でした。";
                else if (player.Score > comp.Score)
                    labelGuidance.Text = "あなたの勝ちです。お疲れ様でした。";
                else
                    labelGuidance.Text = "コンピュータの勝ちです。お疲れ様でした。";

                buttonRestart.Enabled = true;
            }
        }

        // カードの生成
        private void createCards(ref Card[] cards)
        {
            string[] picture = {
                "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"
            };

            // カードのインスタンスの生成
            cards = new Card[picture.Length * 2];
            for (int i = 0, j = 0; i < cards.Length; i += 2, j++)
            {
                cards[i] = new Card(picture[j]);
                cards[i + 1] = new Card(picture[j]);
            }
        }


        // カードを混ぜる
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
        
        private int judge(Card[] cards1, int index1, Card[] cards2, int index2)
        {
            if (index1 < 0 || index1 >= cards1.Length ||
                index2 < 0 || index2 >= cards2.Length)
                return 0;

            // カードの絵柄から点数を算出する
            string[] pictures = {
                "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"
            };
            int[] scores = {
                14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13
            };

            int score1 = 0;
            for (int i = 0; i <= pictures.Length; i++)
            {
                if (cards1[index1].Picture == pictures[i])
                {
                    score1 = scores[i];
                    break;
                }
            }

            int score2 = 0;
            for (int i = 0; i <= pictures.Length; i++)
            {
                if (cards2[index2].Picture == pictures[i])
                {
                    score2 = scores[i];
                    break;
                }
            }

            // 判定
            if (score1 == score2)
                return 1;   // 引き分け
            else if (score1 > score2)
                return 2;   // 勝ち
            else
                return 0;   // 負け
        }
        
        private bool areAllOpen(Card[] cards)
        {
            foreach (Card c in cards)
            {
                if (c.State == false)
                    return false;
            }
            return true;
        }

        private void buttonRestart_Click_1(object sender, EventArgs e)
        {
            shuffleCard(wholeCards);

            // カードを分ける
            Array.Copy(wholeCards, playerCards, playerCards.Length);
            Array.Copy(wholeCards, playerCards.Length, compCards, 0, compCards.Length);

            // 全部のカードを伏せる
            foreach (Card c in playerCards)
            {
                c.Close();
            }
            foreach (Card c in compCards)
            {
                c.Close();
            }
            
            player.Reset();
            player.Score = 0;
            comp.Reset();
            comp.ClearCards();
            comp.Score = 0;

            labelCompScore.Text = comp.Score.ToString();
            labelPlayerScore.Text = player.Score.ToString();

            labelGuidance.Text = "カードを選んでください。";
            buttonRestart.Enabled = false;
        }
    }
}
