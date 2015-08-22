/*
 * Created by SharpDevelop.
 * User: bruno
 * Date: 22/08/2015
 * Time: 04:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace programaDB
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
	
		
		private void BtnOkClick(object sender, EventArgs e)
		{
			clnBancoDados objClnBanco = new clnBancoDados();
			//objClnBanco.senhaSys = txtSenhaSys.Text;
			objClnBanco.AbreBanco();
			
		
		}
		
		private void BtnLimparClick(object sender, EventArgs e)
		{
			txtSenhaSys.Clear();
			txtNomeUser.Clear();
			txtSenhaUser.Clear();
		}
	}
}
