using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hayDayCalculator
{
    [Serializable]
    public partial class frmProfit : Form
    {
        private const string FICHIER = "Produits.dat";

        List<Produit> lstProduits;
        Produit produitActuel;

        public Produit ProduitActuel { get => produitActuel; set => produitActuel = value; }

        public frmProfit()
        {
            ProduitActuel = new Produit();

            lstProduits = new List<Produit>() {
                new Produit("Exemple", 10, 1, 600, 1)
            };
            InitializeComponent();
        }

        private void Serialisation(List<Produit> produits)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(FICHIER, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, produits);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Serialization error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Produit> Deserialization()
        {
            List<Produit> deserializedList = new List<Produit>();
            try
            {
                if (File.Exists(FICHIER))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (Stream stream = new FileStream(FICHIER, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        deserializedList = (List<Produit>)formatter.Deserialize(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deserialization error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (deserializedList.Count <= 0)
            {
                deserializedList.Add(new Produit());
            }

            return deserializedList;
        }

        public bool ProduitExiste()
        {
            bool produitExiste = false;

            if (dataProduit.Rows.Count > 0)
            {
                string nomProduitRecherche = ProduitActuel.Nom;
                int indexColonneNom = dataProduit.Columns["Nom"].Index;

                foreach (DataGridViewRow row in dataProduit.Rows)
                {
                    if (row.Cells[indexColonneNom].Value != null &&
                        row.Cells[indexColonneNom].Value.ToString() == nomProduitRecherche)
                    {
                        produitExiste = true;
                        break;  // On a trouvé le produit, pas besoin de continuer la recherche
                    }
                }

            }

            return produitExiste;


        }

        public void UpdateView()
        {
            if (dataProduit.Rows.Count > 0)
            {

                int total = 0;
                if (ProduitActuel.Prix > 0)
                {
                    if (!ProduitExiste())
                    {
                        dataProduit.Rows.Add(ProduitActuel.Nom, ProduitActuel.Prix, ProduitActuel.Cout, nudQte.Value, ProduitActuel.TempsSecondes, ProduitActuel.CalculerProfit(Convert.ToInt32(nudQte.Value)));
                    }
                    else
                    {
                        // Si le produit existe, recherchez la ligne correspondante et mettez à jour les valeurs
                        foreach (DataGridViewRow row in dataProduit.Rows)
                        {
                            if (row.Cells["Nom"].Value != null && row.Cells["Nom"].Value.ToString() == ProduitActuel.Nom)
                            {
                                // Mettez à jour les valeurs de la ligne existante
                                row.Cells["Prix"].Value = ProduitActuel.Prix;
                                row.Cells["Cout"].Value = ProduitActuel.Cout;
                                row.Cells["Profit"].Value = ProduitActuel.CalculerProfit(Convert.ToInt32(nudQte.Value));
                                row.Cells["TempsSecondes"].Value = ProduitActuel.TempsSecondes;

                                // Vous pouvez également mettre à jour d'autres colonnes au besoin
                                break;  // Sortez de la boucle puisque vous avez trouvé la ligne
                            }
                        }
                    }
                }

                if (dataProduit.Columns.Contains("Profit"))
                {
                    // Itérez sur chaque ligne de la grille
                    foreach (DataGridViewRow row in dataProduit.Rows)
                    {
                        // Vérifiez si la cellule de la colonne "Profit" est valide
                        if (row.Cells["Profit"].Value != null)
                        {
                            // Obtenez la valeur de la cellule "Profit"
                            int profit = Convert.ToInt32(row.Cells["Profit"].Value);

                            total += profit;
                        }
                    }
                }

                lblTotal.Text = "Profit total : " + total.ToString() + "$ par heure";
            }
        }

        private void frmHayDay_Load(object sender, EventArgs e)
        {
            lstProduits = Deserialization();

            // Reste du code d'initialisation
            foreach (Produit produit in lstProduits)
            {
                cbxProduits.Items.Add(produit.Nom);
                dataProduit.Rows.Add(produit.Nom, produit.Prix, produit.Cout, produit.Qte, produit.TempsSecondes, produit.CalculerProfit(produit.Qte));
            }

            cbxProduits.SelectedIndex = 0;
        }

        private void cbxProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataProduit.Rows.Count > 0)
            {
                string nomProduit = cbxProduits.SelectedItem.ToString();

                foreach (Produit produit in lstProduits)
                {
                    if (produit.Nom == nomProduit)
                    {
                        ProduitActuel = produit;
                        break;
                    }
                }

                UpdateView();
            }


        }

        private void nudQte_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataProduit.Rows)
            {
                // Vérifiez si la cellule de la colonne "Profit" est valide
                if (row.Cells["Nom"].Value.ToString() == ProduitActuel.Nom)
                {
                    row.Cells["Qte"].Value = nudQte.Value;
                }
            }
            UpdateView();
        }

        private void dataProduit_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int total = 0;

            if (dataProduit.Columns.Contains("Profit"))
            {
                // Itérez sur chaque ligne de la grille
                foreach (DataGridViewRow row in dataProduit.Rows)
                {
                    // Vérifiez si la cellule de la colonne "Profit" est valide
                    if (row.Cells["Profit"].Value != null)
                    {
                        // Obtenez la valeur de la cellule "Profit"
                        int profit = Convert.ToInt32(row.Cells["Profit"].Value);

                        total += profit;
                    }
                }
            }

            lblTotal.Text = "Profit total : " + total.ToString() + "$ par heure";
        }

        private void dataProduit_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string nom = Convert.ToString(dataProduit.Rows[e.RowIndex].Cells["Nom"].Value);
                int prix = Convert.ToInt32(dataProduit.Rows[e.RowIndex].Cells["Prix"].Value);
                int cout = Convert.ToInt32(dataProduit.Rows[e.RowIndex].Cells["Cout"].Value);
                int tempsSeconde = Convert.ToInt32(dataProduit.Rows[e.RowIndex].Cells["TempsSecondes"].Value);

                nudQte.Value = Convert.ToInt32(dataProduit.Rows[e.RowIndex].Cells["Qte"].Value);
                ProduitActuel = new Produit(nom, prix, cout, tempsSeconde, (int)nudQte.Value);
            }

            UpdateView();
        }

        private void dataProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                object valeur = dataProduit.Rows[e.RowIndex].Cells["Nom"].Value.ToString();

                for (int i = 0; cbxProduits.Items.Count > 0; i++)
                {
                    if (cbxProduits.Items[i].ToString() == valeur.ToString())
                    {
                        cbxProduits.SelectedIndex = i;

                        break;
                    }

                }
            }

        }

        private void btnSupr_Click(object sender, EventArgs e)
        {
            if (dataProduit.SelectedCells.Count > 0)
            {
                int rowIndex = dataProduit.SelectedCells[0].RowIndex;
                string nomProduit = dataProduit.Rows[rowIndex].Cells["Nom"].Value.ToString();

                dataProduit.Rows.RemoveAt(rowIndex);
                cbxProduits.Items.Remove(nomProduit);
                Produit produitToRemove = lstProduits.Find(p => p.Nom == nomProduit);
                if (produitToRemove != null)
                {
                    lstProduits.Remove(produitToRemove);
                }

                if (lstProduits.Count > 0)
                {
                    cbxProduits.SelectedIndex = 0;

                }

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Créez une instance de frmAjouter
            using (frmAjouter formulaireAjouter = new frmAjouter())
            {
                // Affichez frmAjouter en tant que boîte de dialogue modale
                if (formulaireAjouter.ShowDialog() == DialogResult.OK)
                {
                    // Récupérez les valeurs à partir des propriétés de frmAjouter
                    string nom = formulaireAjouter.Nom;
                    int prix = formulaireAjouter.Prix;
                    int cout = formulaireAjouter.Cout;
                    int temps = formulaireAjouter.Temps;

                    ProduitActuel = new Produit(nom, prix, cout, temps, (int)nudQte.Value);
                    cbxProduits.Items.Add(nom);

                    lblTotal.Text = nom;

                    UpdateView();
                }
            }
        }

        private void frmProfit_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Iterate through DataGridView rows and update or add to the list
            foreach (DataGridViewRow row in dataProduit.Rows)
            {
                if (row.Cells["Nom"].Value != null)
                {
                    string nom = Convert.ToString(row.Cells["Nom"].Value);
                    int prix = Convert.ToInt32(row.Cells["Prix"].Value);
                    int cout = Convert.ToInt32(row.Cells["Cout"].Value);
                    int tempsSeconde = Convert.ToInt32(row.Cells["TempsSecondes"].Value);
                    int qte = Convert.ToInt32(row.Cells["Qte"].Value);

                    // Check if the product already exists in the list
                    Produit existingProduit = lstProduits.FirstOrDefault(p => p.Nom == nom);

                    if (existingProduit != null)
                    {
                        // Update existing product
                        existingProduit.Prix = prix;
                        existingProduit.Cout = cout;
                        existingProduit.TempsSecondes = tempsSeconde;
                        existingProduit.Qte = qte;
                    }
                    else
                    {
                        // Add new product to the list
                        lstProduits.Add(new Produit(nom, prix, cout, tempsSeconde, qte));
                    }
                }
            }

            // Serialize the updated list
            Serialisation(lstProduits);
        }

    }
}
