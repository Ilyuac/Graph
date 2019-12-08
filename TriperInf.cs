using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graph
{
    public partial class TriperInf : UserControl
    {
        TextBox text;
        public TriperInf(int Rang)
        {
            InitializeComponent();


            for (int i = 0; i < Rang; i++)
            {
                for (int j = 0; j < Rang; j++)
                {
                    text = new TextBox();
                    text.Name = (i*10+j).ToString();
                    text.Tag = i*10+j;
                    text.Width = 20;
                    text.Text = "0";
                    MatrixPanel.Controls.Add(text);
                }
            }
        }
    }
}
