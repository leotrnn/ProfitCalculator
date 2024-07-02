namespace hayDayCalculator
{
    partial class frmProfit
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfit));
            this.cbxProduits = new System.Windows.Forms.ComboBox();
            this.nudQte = new System.Windows.Forms.NumericUpDown();
            this.dataProduit = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempsSecondes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSupr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxProduits
            // 
            this.cbxProduits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProduits.FormattingEnabled = true;
            this.cbxProduits.Location = new System.Drawing.Point(12, 33);
            this.cbxProduits.Name = "cbxProduits";
            this.cbxProduits.Size = new System.Drawing.Size(226, 32);
            this.cbxProduits.TabIndex = 0;
            this.cbxProduits.SelectedIndexChanged += new System.EventHandler(this.cbxProduits_SelectedIndexChanged);
            // 
            // nudQte
            // 
            this.nudQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQte.Location = new System.Drawing.Point(12, 108);
            this.nudQte.Name = "nudQte";
            this.nudQte.Size = new System.Drawing.Size(226, 29);
            this.nudQte.TabIndex = 12;
            this.nudQte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQte.ValueChanged += new System.EventHandler(this.nudQte_ValueChanged);
            // 
            // dataProduit
            // 
            this.dataProduit.AllowUserToAddRows = false;
            this.dataProduit.AllowUserToResizeColumns = false;
            this.dataProduit.AllowUserToResizeRows = false;
            this.dataProduit.BackgroundColor = System.Drawing.Color.White;
            this.dataProduit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prix,
            this.Cout,
            this.Qte,
            this.TempsSecondes,
            this.Profit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProduit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataProduit.Location = new System.Drawing.Point(244, 10);
            this.dataProduit.Name = "dataProduit";
            this.dataProduit.Size = new System.Drawing.Size(643, 347);
            this.dataProduit.TabIndex = 13;
            this.dataProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProduit_CellClick);
            this.dataProduit.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProduit_CellValueChanged);
            this.dataProduit.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataProduit_RowsRemoved);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix (u)";
            this.Prix.Name = "Prix";
            this.Prix.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Prix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cout
            // 
            this.Cout.HeaderText = "Coût (u)";
            this.Cout.Name = "Cout";
            this.Cout.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cout.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Qte
            // 
            this.Qte.HeaderText = "Quantité";
            this.Qte.Name = "Qte";
            this.Qte.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Qte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TempsSecondes
            // 
            this.TempsSecondes.HeaderText = "Temps (s)";
            this.TempsSecondes.Name = "TempsSecondes";
            this.TempsSecondes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TempsSecondes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit ($/h)";
            this.Profit.Name = "Profit";
            this.Profit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Profit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(244, 360);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(643, 54);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Produit :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quantité :";
            // 
            // btnSupr
            // 
            this.btnSupr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupr.Location = new System.Drawing.Point(11, 197);
            this.btnSupr.Name = "btnSupr";
            this.btnSupr.Size = new System.Drawing.Size(227, 36);
            this.btnSupr.TabIndex = 17;
            this.btnSupr.Text = "Supprimer";
            this.btnSupr.UseVisualStyleBackColor = true;
            this.btnSupr.Click += new System.EventHandler(this.btnSupr_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kurei©";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(11, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 36);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hayDayCalculator.Properties.Resources._default;
            this.pictureBox1.Location = new System.Drawing.Point(11, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 423);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSupr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataProduit);
            this.Controls.Add(this.nudQte);
            this.Controls.Add(this.cbxProduits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProfit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profit Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProfit_FormClosing);
            this.Load += new System.EventHandler(this.frmHayDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxProduits;
        private System.Windows.Forms.NumericUpDown nudQte;
        private System.Windows.Forms.DataGridView dataProduit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSupr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempsSecondes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
    }
}

