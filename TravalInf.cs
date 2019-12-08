using System.Windows.Forms;

namespace Graph
{
    public partial class TravalInf : UserControl
    {
        TextBox text;
        public TravalInf(int Rang)
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
