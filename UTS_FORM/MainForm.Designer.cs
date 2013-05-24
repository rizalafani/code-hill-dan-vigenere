/*
 * Created by SharpDevelop.
 * User: MADARA UCHIHA
 * Date: 13/05/2013
 * Time: 10:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UTS_FORM
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txt_chiper = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_plaintext = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_baris = new System.Windows.Forms.TextBox();
			this.txt_kolom = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_matrik = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_key_vigenere = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label7 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_chiper
			// 
			this.txt_chiper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_chiper.Location = new System.Drawing.Point(12, 147);
			this.txt_chiper.MaxLength = 100000;
			this.txt_chiper.Multiline = true;
			this.txt_chiper.Name = "txt_chiper";
			this.txt_chiper.ReadOnly = true;
			this.txt_chiper.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_chiper.Size = new System.Drawing.Size(826, 266);
			this.txt_chiper.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(27, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Plaintext";
			// 
			// txt_plaintext
			// 
			this.txt_plaintext.Location = new System.Drawing.Point(114, 19);
			this.txt_plaintext.Name = "txt_plaintext";
			this.txt_plaintext.Size = new System.Drawing.Size(450, 20);
			this.txt_plaintext.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(27, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Baris";
			// 
			// txt_baris
			// 
			this.txt_baris.Location = new System.Drawing.Point(114, 45);
			this.txt_baris.Name = "txt_baris";
			this.txt_baris.Size = new System.Drawing.Size(33, 20);
			this.txt_baris.TabIndex = 1;
			// 
			// txt_kolom
			// 
			this.txt_kolom.Location = new System.Drawing.Point(211, 45);
			this.txt_kolom.Name = "txt_kolom";
			this.txt_kolom.Size = new System.Drawing.Size(33, 20);
			this.txt_kolom.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(160, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Kolom";
			// 
			// txt_matrik
			// 
			this.txt_matrik.Location = new System.Drawing.Point(114, 71);
			this.txt_matrik.Name = "txt_matrik";
			this.txt_matrik.Size = new System.Drawing.Size(304, 20);
			this.txt_matrik.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(27, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Matrik";
			// 
			// txt_key_vigenere
			// 
			this.txt_key_vigenere.Location = new System.Drawing.Point(114, 97);
			this.txt_key_vigenere.Name = "txt_key_vigenere";
			this.txt_key_vigenere.Size = new System.Drawing.Size(147, 20);
			this.txt_key_vigenere.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(27, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Vigenere Key";
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(267, 95);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Generate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txt_key_vigenere);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt_plaintext);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txt_matrik);
			this.groupBox1.Controls.Add(this.txt_baris);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_kolom);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(816, 129);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel1.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(654, 42);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(142, 23);
			this.linkLabel1.TabIndex = 16;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Ahmad Rizal Afani";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(602, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(208, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "Application by :";
			// 
			// button3
			// 
			this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.Location = new System.Drawing.Point(343, 95);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 14;
			this.button3.Text = "Copy";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Location = new System.Drawing.Point(343, 43);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(424, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(295, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "Contoh [3,3] : 1,2,3; 4,5,6; 7,8,9;";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(850, 425);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txt_chiper);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UTS KRIPTOGRAFI";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_chiper;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_key_vigenere;
		private System.Windows.Forms.TextBox txt_plaintext;
		private System.Windows.Forms.TextBox txt_baris;
		private System.Windows.Forms.TextBox txt_kolom;
		private System.Windows.Forms.TextBox txt_matrik;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
