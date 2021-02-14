using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csg090_Palmanism
{
   class Card : Button
    {
          
        private const int sizeW = 50, sizeH = 70;
        
        private Color openColor = Color.White;
        
        private Color closedColor = Color.LightSeaGreen;

      
        public Card(string picture)
        {
            Picture = picture;
            State = false;
            base.Size = new Size(sizeW, sizeH);
            base.BackColor = closedColor;
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
            base.BackColor = closedColor;
            base.Text = "";
            base.Enabled = true;   
        }

       
        public void Turn()
        {
            if (State == true)
                Close();        
            else
                Open();         
        }
    }
}
