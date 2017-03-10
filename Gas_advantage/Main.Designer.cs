namespace Gas_advantage
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lb_etanol = new System.Windows.Forms.Label();
            this.lb_gasolina = new System.Windows.Forms.Label();
            this.mtb_etanol = new System.Windows.Forms.MaskedTextBox();
            this.mtb_gasolina = new System.Windows.Forms.MaskedTextBox();
            this.bt_conf = new System.Windows.Forms.Button();
            this.lb_tanque_Gas = new System.Windows.Forms.Label();
            this.lb_tanque_etanol = new System.Windows.Forms.Label();
            this.lb_price_tanque_etanol = new System.Windows.Forms.Label();
            this.lb_price_tanque_gas = new System.Windows.Forms.Label();
            this.lb_compensa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_etanol
            // 
            this.lb_etanol.AutoSize = true;
            this.lb_etanol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_etanol.Location = new System.Drawing.Point(187, 14);
            this.lb_etanol.Name = "lb_etanol";
            this.lb_etanol.Size = new System.Drawing.Size(80, 13);
            this.lb_etanol.TabIndex = 2;
            this.lb_etanol.Text = "R$/L Etanol:";
            // 
            // lb_gasolina
            // 
            this.lb_gasolina.AutoSize = true;
            this.lb_gasolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gasolina.Location = new System.Drawing.Point(12, 14);
            this.lb_gasolina.Name = "lb_gasolina";
            this.lb_gasolina.Size = new System.Drawing.Size(93, 13);
            this.lb_gasolina.TabIndex = 3;
            this.lb_gasolina.Text = "R$/L Gasolina:";
            // 
            // mtb_etanol
            // 
            this.mtb_etanol.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtb_etanol.Location = new System.Drawing.Point(274, 14);
            this.mtb_etanol.Mask = "00,00";
            this.mtb_etanol.Name = "mtb_etanol";
            this.mtb_etanol.Size = new System.Drawing.Size(60, 20);
            this.mtb_etanol.TabIndex = 4;
            this.mtb_etanol.Text = "0000";
            // 
            // mtb_gasolina
            // 
            this.mtb_gasolina.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtb_gasolina.Location = new System.Drawing.Point(111, 11);
            this.mtb_gasolina.Mask = "00,00";
            this.mtb_gasolina.Name = "mtb_gasolina";
            this.mtb_gasolina.Size = new System.Drawing.Size(59, 20);
            this.mtb_gasolina.TabIndex = 5;
            this.mtb_gasolina.Text = "0000";
            // 
            // bt_conf
            // 
            this.bt_conf.Location = new System.Drawing.Point(340, 12);
            this.bt_conf.Name = "bt_conf";
            this.bt_conf.Size = new System.Drawing.Size(45, 23);
            this.bt_conf.TabIndex = 6;
            this.bt_conf.Text = "Conf.";
            this.bt_conf.UseVisualStyleBackColor = true;
            this.bt_conf.Click += new System.EventHandler(this.bt_conf_Click);
            // 
            // lb_tanque_Gas
            // 
            this.lb_tanque_Gas.AutoSize = true;
            this.lb_tanque_Gas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tanque_Gas.Location = new System.Drawing.Point(15, 58);
            this.lb_tanque_Gas.Name = "lb_tanque_Gas";
            this.lb_tanque_Gas.Size = new System.Drawing.Size(88, 15);
            this.lb_tanque_Gas.TabIndex = 7;
            this.lb_tanque_Gas.Text = "Tanque Gas:";
            // 
            // lb_tanque_etanol
            // 
            this.lb_tanque_etanol.AutoSize = true;
            this.lb_tanque_etanol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tanque_etanol.Location = new System.Drawing.Point(190, 58);
            this.lb_tanque_etanol.Name = "lb_tanque_etanol";
            this.lb_tanque_etanol.Size = new System.Drawing.Size(104, 15);
            this.lb_tanque_etanol.TabIndex = 8;
            this.lb_tanque_etanol.Text = "Tanque Etanol:";
            // 
            // lb_price_tanque_etanol
            // 
            this.lb_price_tanque_etanol.AutoSize = true;
            this.lb_price_tanque_etanol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price_tanque_etanol.Location = new System.Drawing.Point(300, 58);
            this.lb_price_tanque_etanol.Name = "lb_price_tanque_etanol";
            this.lb_price_tanque_etanol.Size = new System.Drawing.Size(57, 15);
            this.lb_price_tanque_etanol.TabIndex = 9;
            this.lb_price_tanque_etanol.Text = "R$ 00,00";
            // 
            // lb_price_tanque_gas
            // 
            this.lb_price_tanque_gas.AutoSize = true;
            this.lb_price_tanque_gas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price_tanque_gas.Location = new System.Drawing.Point(108, 60);
            this.lb_price_tanque_gas.Name = "lb_price_tanque_gas";
            this.lb_price_tanque_gas.Size = new System.Drawing.Size(57, 15);
            this.lb_price_tanque_gas.TabIndex = 10;
            this.lb_price_tanque_gas.Text = "R$ 00,00";
            // 
            // lb_compensa
            // 
            this.lb_compensa.AutoSize = true;
            this.lb_compensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_compensa.ForeColor = System.Drawing.Color.Chartreuse;
            this.lb_compensa.Location = new System.Drawing.Point(23, 15);
            this.lb_compensa.Name = "lb_compensa";
            this.lb_compensa.Size = new System.Drawing.Size(20, 25);
            this.lb_compensa.TabIndex = 11;
            this.lb_compensa.Text = "-";
            this.lb_compensa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lb_compensa);
            this.panel1.Location = new System.Drawing.Point(64, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 52);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 157);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_price_tanque_gas);
            this.Controls.Add(this.lb_price_tanque_etanol);
            this.Controls.Add(this.lb_tanque_etanol);
            this.Controls.Add(this.lb_tanque_Gas);
            this.Controls.Add(this.bt_conf);
            this.Controls.Add(this.mtb_gasolina);
            this.Controls.Add(this.mtb_etanol);
            this.Controls.Add(this.lb_gasolina);
            this.Controls.Add(this.lb_etanol);
            this.Icon = ((System.Drawing.Icon)(Properties.Resources.Icon));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Gas Advantage";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_etanol;
        private System.Windows.Forms.Label lb_gasolina;
        private System.Windows.Forms.MaskedTextBox mtb_etanol;
        private System.Windows.Forms.MaskedTextBox mtb_gasolina;
        private System.Windows.Forms.Button bt_conf;
        private System.Windows.Forms.Label lb_tanque_Gas;
        private System.Windows.Forms.Label lb_tanque_etanol;
        private System.Windows.Forms.Label lb_price_tanque_etanol;
        private System.Windows.Forms.Label lb_price_tanque_gas;
        private System.Windows.Forms.Label lb_compensa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

