﻿namespace PublicApiWinClient
{
    partial class Form1
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
            this.textURI = new System.Windows.Forms.TextBox();
            this.textResponseAPI = new System.Windows.Forms.TextBox();
            this.cmdExecuta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdDeserializare = new System.Windows.Forms.Button();
            this.cmdClearDebug = new System.Windows.Forms.Button();
            this.textDebugOuput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.converteste = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sumaDeConvertit = new System.Windows.Forms.NumericUpDown();
            this.valoareDupaConversie = new System.Windows.Forms.NumericUpDown();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sumaDeConvertit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoareDupaConversie)).BeginInit();
            this.SuspendLayout();
            // 
            // textURI
            // 
            this.textURI.Location = new System.Drawing.Point(113, 36);
            this.textURI.Name = "textURI";
            this.textURI.Size = new System.Drawing.Size(404, 20);
            this.textURI.TabIndex = 0;
            // 
            // textResponseAPI
            // 
            this.textResponseAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResponseAPI.Location = new System.Drawing.Point(79, 162);
            this.textResponseAPI.Multiline = true;
            this.textResponseAPI.Name = "textResponseAPI";
            this.textResponseAPI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResponseAPI.Size = new System.Drawing.Size(656, 162);
            this.textResponseAPI.TabIndex = 1;
            // 
            // cmdExecuta
            // 
            this.cmdExecuta.Location = new System.Drawing.Point(545, 33);
            this.cmdExecuta.Name = "cmdExecuta";
            this.cmdExecuta.Size = new System.Drawing.Size(190, 23);
            this.cmdExecuta.TabIndex = 2;
            this.cmdExecuta.Text = "Executa";
            this.cmdExecuta.UseVisualStyleBackColor = true;
            this.cmdExecuta.Click += new System.EventHandler(this.cmdExecuta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Request URI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Raspuns:";
            // 
            // cmdDeserializare
            // 
            this.cmdDeserializare.Location = new System.Drawing.Point(23, 330);
            this.cmdDeserializare.Name = "cmdDeserializare";
            this.cmdDeserializare.Size = new System.Drawing.Size(75, 23);
            this.cmdDeserializare.TabIndex = 5;
            this.cmdDeserializare.Text = "Deserializare";
            this.cmdDeserializare.UseVisualStyleBackColor = true;
            this.cmdDeserializare.Click += new System.EventHandler(this.cmdDeserializare_Click);
            // 
            // cmdClearDebug
            // 
            this.cmdClearDebug.Location = new System.Drawing.Point(104, 330);
            this.cmdClearDebug.Name = "cmdClearDebug";
            this.cmdClearDebug.Size = new System.Drawing.Size(75, 23);
            this.cmdClearDebug.TabIndex = 6;
            this.cmdClearDebug.Text = "Clear Debug";
            this.cmdClearDebug.UseVisualStyleBackColor = true;
            this.cmdClearDebug.Click += new System.EventHandler(this.cmdClearDebug_Click);
            // 
            // textDebugOuput
            // 
            this.textDebugOuput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDebugOuput.Location = new System.Drawing.Point(23, 359);
            this.textDebugOuput.Multiline = true;
            this.textDebugOuput.Name = "textDebugOuput";
            this.textDebugOuput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDebugOuput.Size = new System.Drawing.Size(712, 136);
            this.textDebugOuput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alege monedă:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 538);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Suma:";
            // 
            // converteste
            // 
            this.converteste.Location = new System.Drawing.Point(325, 538);
            this.converteste.Name = "converteste";
            this.converteste.Size = new System.Drawing.Size(121, 25);
            this.converteste.TabIndex = 12;
            this.converteste.Text = "Convertește în:";
            this.converteste.UseVisualStyleBackColor = true;
            this.converteste.Click += new System.EventHandler(this.conversieButton);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Alege monedă:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(470, 538);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Valoare rezultată:";
            // 
            // sumaDeConvertit
            // 
            this.sumaDeConvertit.DecimalPlaces = 6;
            this.sumaDeConvertit.Location = new System.Drawing.Point(43, 538);
            this.sumaDeConvertit.Name = "sumaDeConvertit";
            this.sumaDeConvertit.Size = new System.Drawing.Size(75, 20);
            this.sumaDeConvertit.TabIndex = 17;
            // 
            // valoareDupaConversie
            // 
            this.valoareDupaConversie.DecimalPlaces = 6;
            this.valoareDupaConversie.Location = new System.Drawing.Point(663, 538);
            this.valoareDupaConversie.Name = "valoareDupaConversie";
            this.valoareDupaConversie.Size = new System.Drawing.Size(75, 20);
            this.valoareDupaConversie.TabIndex = 18;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(113, 76);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(100, 20);
            this.textUserName.TabIndex = 19;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(313, 76);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(145, 20);
            this.textPassword.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(113, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 45);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auth Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(313, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 45);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Technique";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "User Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 606);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.valoareDupaConversie);
            this.Controls.Add(this.sumaDeConvertit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.converteste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDebugOuput);
            this.Controls.Add(this.cmdClearDebug);
            this.Controls.Add(this.cmdDeserializare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdExecuta);
            this.Controls.Add(this.textResponseAPI);
            this.Controls.Add(this.textURI);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sumaDeConvertit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoareDupaConversie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textURI;
        private System.Windows.Forms.TextBox textResponseAPI;
        private System.Windows.Forms.Button cmdExecuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdDeserializare;
        private System.Windows.Forms.Button cmdClearDebug;
        private System.Windows.Forms.TextBox textDebugOuput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button converteste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sumaDeConvertit;
        private System.Windows.Forms.NumericUpDown valoareDupaConversie;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
