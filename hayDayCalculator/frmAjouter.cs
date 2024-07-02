using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hayDayCalculator
{
    public partial class frmAjouter : Form
    {
        public string Nom { get; private set; }
        public int Prix { get; private set; }
        public int Cout { get; private set; }
        public int Temps { get; private set; }

        public frmAjouter()
        {
            InitializeComponent();
        }

        private void tbxNom_TextChanged(object sender, EventArgs e)
        {
            if (tbxNom.Text != "")
            {
                btnAjouter.Enabled = true;
            }
            else
            {
                btnAjouter.Enabled = false;
            }
        }

        private void champs_Click(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox tbx = (TextBox)sender;
                if (tbx.Name == "tbxNom")
                {
                    tbxAide.Text = "Correspond au nom du produit";
                }
            }
            else if (sender is NumericUpDown)
            {
                NumericUpDown nud = (NumericUpDown)sender;
                if (nud.Name == "nudPrix")
                {
                    tbxAide.Text = "Correspond au prix auquel le produit sera vendu";
                }
                else if (nud.Name == "nudCout")
                {
                    tbxAide.Text = "Correspond au coût de production du produit";
                }
                else if (nud.Name == "nudTemps")
                {
                    tbxAide.Text = "Correspond à l'interval entre chaque achat du produit en seconde";
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Affectez les valeurs des champs aux propriétés
            Nom = tbxNom.Text;
            Prix = Convert.ToInt32(nudPrix.Value);
            Cout = Convert.ToInt32(nudCout.Value);
            Temps = Convert.ToInt32(nudTemps.Value);

            // Fermez le formulaire avec DialogResult.OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void tbxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifiez si la touche pressée est Backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                // Autoriser la touche Backspace (ne rien faire)
                e.Handled = false;
            }
            else if (tbxNom.Text.Length + 1 > 10)
            {
                // Bloquer la touche en définissant Handled sur true
                e.Handled = true;
            }
            else
            {
                // Autoriser la touche
                e.Handled = false;
            }

        }
    }
}
