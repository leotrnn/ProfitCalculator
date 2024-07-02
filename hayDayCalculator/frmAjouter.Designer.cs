namespace hayDayCalculator
{
    partial class frmAjouter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouter));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tbxAide = new System.Windows.Forms.TextBox();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.nudCout = new System.Windows.Forms.NumericUpDown();
            this.nudTemps = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemps)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coût :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temps :";
            // 
            // tbxNom
            // 
            this.tbxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNom.Location = new System.Drawing.Point(98, 13);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(209, 29);
            this.tbxNom.TabIndex = 4;
            this.tbxNom.Click += new System.EventHandler(this.champs_Click);
            this.tbxNom.TextChanged += new System.EventHandler(this.tbxNom_TextChanged);
            this.tbxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNom_KeyPress);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Enabled = false;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(16, 157);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(291, 35);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // tbxAide
            // 
            this.tbxAide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAide.Location = new System.Drawing.Point(16, 198);
            this.tbxAide.Multiline = true;
            this.tbxAide.Name = "tbxAide";
            this.tbxAide.ReadOnly = true;
            this.tbxAide.Size = new System.Drawing.Size(291, 58);
            this.tbxAide.TabIndex = 6;
            // 
            // nudPrix
            // 
            this.nudPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrix.Location = new System.Drawing.Point(98, 48);
            this.nudPrix.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrix.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrix.Name = "nudPrix";
            this.nudPrix.Size = new System.Drawing.Size(209, 29);
            this.nudPrix.TabIndex = 7;
            this.nudPrix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrix.Click += new System.EventHandler(this.champs_Click);
            // 
            // nudCout
            // 
            this.nudCout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCout.Location = new System.Drawing.Point(98, 84);
            this.nudCout.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCout.Name = "nudCout";
            this.nudCout.Size = new System.Drawing.Size(209, 29);
            this.nudCout.TabIndex = 8;
            this.nudCout.Click += new System.EventHandler(this.champs_Click);
            // 
            // nudTemps
            // 
            this.nudTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTemps.Location = new System.Drawing.Point(98, 119);
            this.nudTemps.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.nudTemps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTemps.Name = "nudTemps";
            this.nudTemps.Size = new System.Drawing.Size(209, 29);
            this.nudTemps.TabIndex = 9;
            this.nudTemps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTemps.Click += new System.EventHandler(this.champs_Click);
            // 
            // frmAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 268);
            this.Controls.Add(this.nudTemps);
            this.Controls.Add(this.nudCout);
            this.Controls.Add(this.nudPrix);
            this.Controls.Add(this.tbxAide);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAjouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un produit";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox tbxAide;
        private System.Windows.Forms.NumericUpDown nudPrix;
        private System.Windows.Forms.NumericUpDown nudCout;
        private System.Windows.Forms.NumericUpDown nudTemps;
    }
}