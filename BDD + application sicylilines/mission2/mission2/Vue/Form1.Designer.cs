namespace mission2
{
    partial class Form1
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
            this.ajouter = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.listboxLiaison = new System.Windows.Forms.ListBox();
            this.listboxSecteur = new System.Windows.Forms.ListBox();
            this.modifbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sicilylines = new System.Windows.Forms.TextBox();
            this.portArrivee = new System.Windows.Forms.ComboBox();
            this.portDepart = new System.Windows.Forms.ComboBox();
            this.portA = new System.Windows.Forms.Label();
            this.portD = new System.Windows.Forms.Label();
            this.duree = new System.Windows.Forms.Label();
            this.dureeAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.SystemColors.Highlight;
            this.ajouter.Location = new System.Drawing.Point(37, 177);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 0;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.Yellow;
            this.modifier.Location = new System.Drawing.Point(187, 110);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(75, 23);
            this.modifier.TabIndex = 1;
            this.modifier.Text = "modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Red;
            this.supprimer.Location = new System.Drawing.Point(315, 92);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(75, 23);
            this.supprimer.TabIndex = 2;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // listboxLiaison
            // 
            this.listboxLiaison.FormattingEnabled = true;
            this.listboxLiaison.Location = new System.Drawing.Point(426, 104);
            this.listboxLiaison.Name = "listboxLiaison";
            this.listboxLiaison.Size = new System.Drawing.Size(118, 82);
            this.listboxLiaison.TabIndex = 4;
            this.listboxLiaison.SelectedIndexChanged += new System.EventHandler(this.liaison_SelectedIndexChanged);
            // 
            // listboxSecteur
            // 
            this.listboxSecteur.FormattingEnabled = true;
            this.listboxSecteur.Location = new System.Drawing.Point(203, 104);
            this.listboxSecteur.Name = "listboxSecteur";
            this.listboxSecteur.Size = new System.Drawing.Size(124, 82);
            this.listboxSecteur.TabIndex = 5;
            this.listboxSecteur.SelectedIndexChanged += new System.EventHandler(this.secteur_SelectedIndexChanged);
            // 
            // modifbox
            // 
            this.modifbox.Location = new System.Drawing.Point(175, 84);
            this.modifbox.Name = "modifbox";
            this.modifbox.Size = new System.Drawing.Size(105, 20);
            this.modifbox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dureeAdd);
            this.groupBox1.Controls.Add(this.duree);
            this.groupBox1.Controls.Add(this.portD);
            this.groupBox1.Controls.Add(this.portA);
            this.groupBox1.Controls.Add(this.portDepart);
            this.groupBox1.Controls.Add(this.portArrivee);
            this.groupBox1.Controls.Add(this.modifier);
            this.groupBox1.Controls.Add(this.modifbox);
            this.groupBox1.Controls.Add(this.ajouter);
            this.groupBox1.Controls.Add(this.supprimer);
            this.groupBox1.Location = new System.Drawing.Point(166, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 218);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sicilylines
            // 
            this.sicilylines.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sicilylines.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sicilylines.ForeColor = System.Drawing.Color.Aqua;
            this.sicilylines.Location = new System.Drawing.Point(203, 20);
            this.sicilylines.Name = "sicilylines";
            this.sicilylines.Size = new System.Drawing.Size(314, 45);
            this.sicilylines.TabIndex = 9;
            this.sicilylines.Text = "Sicilylines";
            this.sicilylines.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // portArrivee
            // 
            this.portArrivee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portArrivee.FormattingEnabled = true;
            this.portArrivee.Location = new System.Drawing.Point(17, 68);
            this.portArrivee.Name = "portArrivee";
            this.portArrivee.Size = new System.Drawing.Size(121, 21);
            this.portArrivee.TabIndex = 8;
            // 
            // portDepart
            // 
            this.portDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portDepart.FormattingEnabled = true;
            this.portDepart.Location = new System.Drawing.Point(17, 108);
            this.portDepart.Name = "portDepart";
            this.portDepart.Size = new System.Drawing.Size(121, 21);
            this.portDepart.TabIndex = 9;
            // 
            // portA
            // 
            this.portA.AutoSize = true;
            this.portA.Location = new System.Drawing.Point(44, 52);
            this.portA.Name = "portA";
            this.portA.Size = new System.Drawing.Size(69, 13);
            this.portA.TabIndex = 10;
            this.portA.Text = "Port d\'arrivée";
            // 
            // portD
            // 
            this.portD.AutoSize = true;
            this.portD.Location = new System.Drawing.Point(44, 92);
            this.portD.Name = "portD";
            this.portD.Size = new System.Drawing.Size(74, 13);
            this.portD.TabIndex = 11;
            this.portD.Text = "Port de depart";
            // 
            // duree
            // 
            this.duree.AutoSize = true;
            this.duree.Location = new System.Drawing.Point(207, 68);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(34, 13);
            this.duree.TabIndex = 12;
            this.duree.Text = "durée";
            // 
            // dureeAdd
            // 
            this.dureeAdd.Location = new System.Drawing.Point(25, 151);
            this.dureeAdd.Name = "dureeAdd";
            this.dureeAdd.Size = new System.Drawing.Size(105, 20);
            this.dureeAdd.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "durée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "AJOUTER LIAISON:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "MODIFIER LIAISON:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "SUPP LIAISON:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Les secteurs";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(426, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Les liaisons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mission2.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sicilylines);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listboxSecteur);
            this.Controls.Add(this.listboxLiaison);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.ListBox listboxLiaison;
        private System.Windows.Forms.TextBox modifbox;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox sicilylines;
        private System.Windows.Forms.ListBox listboxSecteur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dureeAdd;
        private System.Windows.Forms.Label duree;
        private System.Windows.Forms.Label portD;
        private System.Windows.Forms.Label portA;
        private System.Windows.Forms.ComboBox portDepart;
        private System.Windows.Forms.ComboBox portArrivee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

