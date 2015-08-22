/*
 * Created by SharpDevelop.
 * User: bruno
 * Date: 22/08/2015
 * Time: 04:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace programaDB
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
			this.txtSenhaSys = new System.Windows.Forms.TextBox();
			this.txtNomeUser = new System.Windows.Forms.TextBox();
			this.txtSenhaUser = new System.Windows.Forms.TextBox();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSenhaSys
			// 
			this.txtSenhaSys.Location = new System.Drawing.Point(133, 22);
			this.txtSenhaSys.Name = "txtSenhaSys";
			this.txtSenhaSys.Size = new System.Drawing.Size(207, 20);
			this.txtSenhaSys.TabIndex = 0;
			this.txtSenhaSys.UseSystemPasswordChar = true;
			// 
			// txtNomeUser
			// 
			this.txtNomeUser.Location = new System.Drawing.Point(133, 62);
			this.txtNomeUser.Name = "txtNomeUser";
			this.txtNomeUser.Size = new System.Drawing.Size(207, 20);
			this.txtNomeUser.TabIndex = 1;
			// 
			// txtSenhaUser
			// 
			this.txtSenhaUser.Location = new System.Drawing.Point(133, 88);
			this.txtSenhaUser.Name = "txtSenhaUser";
			this.txtSenhaUser.Size = new System.Drawing.Size(207, 20);
			this.txtSenhaUser.TabIndex = 2;
			this.txtSenhaUser.UseSystemPasswordChar = true;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(221, 114);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(55, 55);
			this.btnLimpar.TabIndex = 3;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(282, 114);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(55, 55);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(160, 114);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(55, 55);
			this.button3.TabIndex = 5;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Senha do SYSDBA :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Nome do Usuário :";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Senha do Usuário :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnLimpar);
			this.groupBox1.Controls.Add(this.btnOk);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtSenhaSys);
			this.groupBox1.Controls.Add(this.txtSenhaUser);
			this.groupBox1.Controls.Add(this.txtNomeUser);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(353, 177);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 208);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "programaCriarBancoOracle";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.TextBox txtSenhaUser;
		public System.Windows.Forms.TextBox txtNomeUser;
		public System.Windows.Forms.TextBox txtSenhaSys;
	}
}
