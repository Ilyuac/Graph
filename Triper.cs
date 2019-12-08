using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graph
{
    public partial class Triper : Form
    {
        public Triper(int rang)
        {
            InitializeComponent();

            this.triperInf = new TriperInf(rang);
            // 
            // triperInf
            // 
            this.triperInf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triperInf.Location = new System.Drawing.Point(0, 0);
            this.triperInf.Name = "triperInf";
            this.triperInf.Size = new System.Drawing.Size(800, 450);
            this.triperInf.TabIndex = 0;
            this.Controls.Add(this.triperInf);



            this.Height = (rang - 1) * 25;
            this.Width = (rang - 1) * 30;
        }

        private void Triper_FormClosing(object sender, FormClosingEventArgs e)
        {
            int h = 0;
            for(int i=0;i<Graph.VCount;i++)
            {
                for(int j=0;j<Graph.VCount;j++)
                {
                    for(int edge=0; edge<Graph.ECount; edge++)
                    {
                        if(Graph.E[edge].Vertex1==i && Graph.E[edge].Vertex2==j)
                        {
                            Graph.E[edge].Weight = Convert.ToInt32(triperInf.Controls["MatrixPanel"].Controls[h].Text); 
                        }
                    }
                    h++;
                }
            }
        }
    }
}
