using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace csg091_CardsWar
{
    class Card : Button
    {
         
        private const int sizeW = 50, sizeH = 70;
        private Color openColor = Color.White;
        private Color closeColor = Color.LightSeaGreen;

        public Card(string picture)
        {
            Picture = picture;
            State = false;
            base.Size = new Size(sizeW, sizeH);
            base.BackColor = closeColor;
            base.Font = new Font("MS UI Gothic", 14, FontStyle.Bold);
            base.Enabled = false;
        }

        public string Picture { get; set; }
        public bool State { get; set; }

        public void Open()
        {
            State = true;
            base.BackColor = openColor;
            base.Text = Picture;
            base.Enabled = false;
        }

        public void Close()
        {
            State = false;
            base.Text = "";
            base.BackColor = closeColor;
            base.Enabled = true;
        }

        public void Turn()
        {
            if (State)
                Close();
            else
                Open();
        }
    }
}
