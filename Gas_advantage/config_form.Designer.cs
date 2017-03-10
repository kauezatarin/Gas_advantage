namespace Gas_advantage
{
    partial class config_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(config_form));
            this.lb_tanque = new System.Windows.Forms.Label();
            this.lb_gasolina = new System.Windows.Forms.Label();
            this.lb_etanol = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.tb_tanque = new System.Windows.Forms.TextBox();
            this.tb_gasolina = new System.Windows.Forms.TextBox();
            this.tb_etanol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_tanque
            // 
            this.lb_tanque.AutoSize = true;
            this.lb_tanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tanque.Location = new System.Drawing.Point(13, 18);
            this.lb_tanque.Name = "lb_tanque";
            this.lb_tanque.Size = new System.Drawing.Size(139, 15);
            this.lb_tanque.TabIndex = 0;
            this.lb_tanque.Text = "Tamanho do tanque:";
            // 
            // lb_gasolina
            // 
            this.lb_gasolina.AutoSize = true;
            this.lb_gasolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gasolina.Location = new System.Drawing.Point(13, 52);
            this.lb_gasolina.Name = "lb_gasolina";
            this.lb_gasolina.Size = new System.Drawing.Size(99, 15);
            this.lb_gasolina.TabIndex = 1;
            this.lb_gasolina.Text = "Km/l gasolina:";
            // 
            // lb_etanol
            // 
            this.lb_etanol.AutoSize = true;
            this.lb_etanol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_etanol.Location = new System.Drawing.Point(13, 91);
            this.lb_etanol.Name = "lb_etanol";
            this.lb_etanol.Size = new System.Drawing.Size(85, 15);
            this.lb_etanol.TabIndex = 2;
            this.lb_etanol.Text = "Km/l Etanol:";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(251, 90);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 3;
            this.bt_save.Text = "Salvar";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // tb_tanque
            // 
            this.tb_tanque.Location = new System.Drawing.Point(158, 13);
            this.tb_tanque.Name = "tb_tanque";
            this.tb_tanque.Size = new System.Drawing.Size(54, 20);
            this.tb_tanque.TabIndex = 4;
            this.tb_tanque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_only);
            // 
            // tb_gasolina
            // 
            this.tb_gasolina.Location = new System.Drawing.Point(118, 47);
            this.tb_gasolina.Name = "tb_gasolina";
            this.tb_gasolina.Size = new System.Drawing.Size(54, 20);
            this.tb_gasolina.TabIndex = 5;
            this.tb_gasolina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_only);
            // 
            // tb_etanol
            // 
            this.tb_etanol.Location = new System.Drawing.Point(104, 86);
            this.tb_etanol.Name = "tb_etanol";
            this.tb_etanol.Size = new System.Drawing.Size(54, 20);
            this.tb_etanol.TabIndex = 6;
            this.tb_etanol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_only);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "litros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Km";
            // 
            // config_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 125);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_etanol);
            this.Controls.Add(this.tb_gasolina);
            this.Controls.Add(this.tb_tanque);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.lb_etanol);
            this.Controls.Add(this.lb_gasolina);
            this.Controls.Add(this.lb_tanque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "config_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "config_form";
            this.Load += new System.EventHandler(this.config_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tanque;
        private System.Windows.Forms.Label lb_gasolina;
        private System.Windows.Forms.Label lb_etanol;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TextBox tb_tanque;
        private System.Windows.Forms.TextBox tb_gasolina;
        private System.Windows.Forms.TextBox tb_etanol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}