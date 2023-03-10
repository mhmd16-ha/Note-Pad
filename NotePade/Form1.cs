namespace NotePade
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
           path = null;
        }



        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                rtx_txt.SaveFile(saveFD.FileName);
                rtx_txt.Clear();
                path = null;

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if( openFD.ShowDialog() == DialogResult.OK)
            {
                rtx_txt.LoadFile(openFD.FileName);
                path = openFD.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(path == null)
            {
                saveAsToolStripMenuItem_Click(null, null);
            }
            else {
                rtx_txt.SaveFile(path);
                rtx_txt.Clear();
                path = null;
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(rtx_txt.Text != "")
            {
                if(MessageBox.Show("Are You Want To Save ?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtx_txt.Text != "")
            {
                if (MessageBox.Show("Are You Want To Save ?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
            path = null;
            rtx_txt.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (fontD.ShowDialog() == DialogResult.OK)
            {
                if(rtx_txt.SelectedText != "")
                {
                    rtx_txt.SelectionFont= fontD.Font; 
                }
                else
                rtx_txt.Font=fontD.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rtx_txt.SelectedText != "")
                {
                    rtx_txt.SelectionColor = colorD.Color;
                }
                else
                    rtx_txt.ForeColor = colorD.Color;
            }
        }

        private void backColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rtx_txt.SelectedText != "")
                {
                    rtx_txt.SelectionBackColor = colorD.Color;
                }
                else
                    rtx_txt.BackColor = colorD.Color;
            }
        }
    }
}