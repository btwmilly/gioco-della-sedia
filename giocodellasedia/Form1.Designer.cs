namespace giocodellasedia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBambini = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSedie = new TextBox();
            btnAvviaGioco = new Button();
            lblStatoGioco = new Label();
            listBoxGiocatori = new ListBox();
            SuspendLayout();
            // 
            // txtBambini
            // 
            txtBambini.Location = new Point(85, 118);
            txtBambini.Name = "txtBambini";
            txtBambini.Size = new Size(125, 27);
            txtBambini.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 84);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 1;
            label1.Text = "Inserisci il numero di bambini:\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 84);
            label2.Name = "label2";
            label2.Size = new Size(187, 40);
            label2.TabIndex = 2;
            label2.Text = "Inserisci il numero di sedie:\r\n\r\n";
            // 
            // txtSedie
            // 
            txtSedie.Location = new Point(468, 118);
            txtSedie.Name = "txtSedie";
            txtSedie.Size = new Size(125, 27);
            txtSedie.TabIndex = 3;
            // 
            // btnAvviaGioco
            // 
            btnAvviaGioco.Location = new Point(272, 229);
            btnAvviaGioco.Name = "btnAvviaGioco";
            btnAvviaGioco.Size = new Size(164, 29);
            btnAvviaGioco.TabIndex = 4;
            btnAvviaGioco.Text = "Avvia Gioco";
            btnAvviaGioco.UseVisualStyleBackColor = true;
            btnAvviaGioco.Click += btnAvviaGioco_Click;
            // 
            // lblStatoGioco
            // 
            lblStatoGioco.AutoSize = true;
            lblStatoGioco.Location = new Point(329, 189);
            lblStatoGioco.Name = "lblStatoGioco";
            lblStatoGioco.Size = new Size(0, 20);
            lblStatoGioco.TabIndex = 5;
            // 
            // listBoxGiocatori
            // 
            listBoxGiocatori.FormattingEnabled = true;
            listBoxGiocatori.Location = new Point(48, 269);
            listBoxGiocatori.Name = "listBoxGiocatori";
            listBoxGiocatori.Size = new Size(150, 104);
            listBoxGiocatori.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxGiocatori);
            Controls.Add(lblStatoGioco);
            Controls.Add(btnAvviaGioco);
            Controls.Add(txtSedie);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBambini);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt;
        private TextBox txtBambini;
        private Label label1;
        private Label label2;
        private TextBox txtSedie;
        private Button btnAvviaGioco;
        private Label lblStatoGioco;
        private ListBox listBoxGiocatori;
    }
}
