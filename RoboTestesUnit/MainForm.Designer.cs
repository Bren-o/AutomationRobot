/*
 * Created by SharpDevelop.
 * User: Breno Alves
 * Date: 10/01/2023
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RoboTestesUnit
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_map;
		private System.Windows.Forms.Button btn_stop;
		private System.Windows.Forms.Button btn_txt;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader step;
		private System.Windows.Forms.ColumnHeader type;
		private System.Windows.Forms.ColumnHeader value;
		private System.Windows.Forms.Label lbl_X;
		private System.Windows.Forms.Label lbl_y;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Button btn_Clear;
		
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
			this.btn_map = new System.Windows.Forms.Button();
			this.btn_stop = new System.Windows.Forms.Button();
			this.btn_txt = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.value = new System.Windows.Forms.ColumnHeader();
			this.step = new System.Windows.Forms.ColumnHeader();
			this.type = new System.Windows.Forms.ColumnHeader();
			this.lbl_X = new System.Windows.Forms.Label();
			this.lbl_y = new System.Windows.Forms.Label();
			this.btn_start = new System.Windows.Forms.Button();
			this.btn_Clear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_map
			// 
			this.btn_map.Location = new System.Drawing.Point(152, 12);
			this.btn_map.Name = "btn_map";
			this.btn_map.Size = new System.Drawing.Size(101, 24);
			this.btn_map.TabIndex = 0;
			this.btn_map.Text = "MAPEAR";
			this.btn_map.UseVisualStyleBackColor = true;
			this.btn_map.Click += new System.EventHandler(this.Btn_mapClick);
			// 
			// btn_stop
			// 
			this.btn_stop.Enabled = false;
			this.btn_stop.Location = new System.Drawing.Point(259, 12);
			this.btn_stop.Name = "btn_stop";
			this.btn_stop.Size = new System.Drawing.Size(111, 24);
			this.btn_stop.TabIndex = 1;
			this.btn_stop.Text = "PARAR";
			this.btn_stop.UseVisualStyleBackColor = true;
			this.btn_stop.Click += new System.EventHandler(this.Btn_stopClick);
			// 
			// btn_txt
			// 
			this.btn_txt.Enabled = false;
			this.btn_txt.Location = new System.Drawing.Point(152, 42);
			this.btn_txt.Name = "btn_txt";
			this.btn_txt.Size = new System.Drawing.Size(218, 23);
			this.btn_txt.TabIndex = 2;
			this.btn_txt.Text = "DIGITAR TEXTO";
			this.btn_txt.UseVisualStyleBackColor = true;
			this.btn_txt.Click += new System.EventHandler(this.Btn_txtClick);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.value,
			this.step,
			this.type});
			this.listView1.Location = new System.Drawing.Point(2, 132);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(403, 243);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// value
			// 
			this.value.DisplayIndex = 1;
			this.value.Text = "Valor";
			this.value.Width = 100;
			// 
			// step
			// 
			this.step.DisplayIndex = 0;
			this.step.Text = "Etapa";
			this.step.Width = 100;
			// 
			// type
			// 
			this.type.Text = "Tipo";
			this.type.Width = 100;
			// 
			// lbl_X
			// 
			this.lbl_X.Location = new System.Drawing.Point(22, 22);
			this.lbl_X.Name = "lbl_X";
			this.lbl_X.Size = new System.Drawing.Size(100, 23);
			this.lbl_X.TabIndex = 4;
			this.lbl_X.Text = "X:";
			// 
			// lbl_y
			// 
			this.lbl_y.Location = new System.Drawing.Point(22, 62);
			this.lbl_y.Name = "lbl_y";
			this.lbl_y.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_y.Size = new System.Drawing.Size(100, 23);
			this.lbl_y.TabIndex = 5;
			this.lbl_y.Text = "Y:";
			// 
			// btn_start
			// 
			this.btn_start.Enabled = false;
			this.btn_start.Location = new System.Drawing.Point(152, 71);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(218, 23);
			this.btn_start.TabIndex = 6;
			this.btn_start.Text = "COMEÇAR";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.Btn_startClick);
			// 
			// btn_Clear
			// 
			this.btn_Clear.Enabled = false;
			this.btn_Clear.Location = new System.Drawing.Point(152, 100);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(218, 23);
			this.btn_Clear.TabIndex = 7;
			this.btn_Clear.Text = "LIMPAR";
			this.btn_Clear.UseVisualStyleBackColor = true;
			this.btn_Clear.Click += new System.EventHandler(this.Btn_ClearClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 377);
			this.Controls.Add(this.btn_Clear);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.lbl_y);
			this.Controls.Add(this.lbl_X);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btn_txt);
			this.Controls.Add(this.btn_stop);
			this.Controls.Add(this.btn_map);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "RoboTestesUnit";
			this.Deactivate += new System.EventHandler(this.MainFormDeactivate);
			this.ResumeLayout(false);

		}
	}
}
