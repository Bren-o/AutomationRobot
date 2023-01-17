using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using System.Runtime.InteropServices;


namespace RoboTestesUnit
{

	public partial class MainForm : Form
	{
		List<Command> commands = new List<Command>();
		public bool mapeamento = false;
		public int etapa = 1;
		
		public MainForm()
		{
			InitializeComponent();	
		}
		
		void Btn_mapClick(object sender, EventArgs e)
		{
			mapeamento = true;
			
			btn_map.Enabled = false;
			btn_stop.Enabled = true;
			btn_Clear.Enabled = false;
			btn_txt.Enabled = true;
			btn_start.Enabled = false;
		
			new Thread(new ThreadStart(Mapear)).Start();
		}
		
		public delegate void Del();
	 	
		void ThreadProc()
		{
			//Mostra as coordenadas do mouse
			
			int x = MousePosition.X;
			int y = MousePosition.Y;
				
			lbl_X.Text = "X:"+x.ToString();
			lbl_y.Text = "Y:"+y.ToString();
		}
		
		void Mapear()
		{
			while(mapeamento)
			{
				Invoke(new Del(ThreadProc));
			}
		}
		
		void MainFormDeactivate(object sender, EventArgs e)
		{
			//Abre o form quando clica fora
			new Thread(new ThreadStart(CallFormAgain)).Start();
			
			// adiciona os cliques fora do form
			if(mapeamento)
			{
				commands.Add(new Command {Type = "Click", Value = MousePosition});
				
				listView1.Items.Add(new ListViewItem(new String[]
				                                     	{
				                                     	string.Concat(
				                                     		MousePosition.X.ToString(),
				                                     		", ",
				                                     		MousePosition.Y.ToString()),
				                                     	etapa.ToString(),
				                                     	"Click"
				                                     	}
				                                    ));
				etapa++;
			}
		}
		
		void CallForm()
		{
			if(WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;
			else
			{
				WindowState = FormWindowState.Normal;
				TopMost = true;
				BringToFront();
			}
			
			Activate();
		}
		
		void CallFormAgain()
		{
			if(mapeamento)
			Invoke(new Del(CallForm));
		}
		
		void Btn_stopClick(object sender, EventArgs e)
		{
			mapeamento = false;
			
			btn_map.Enabled = true;
			btn_stop.Enabled = false; 
			btn_Clear.Enabled = true;
			btn_txt.Enabled = false;
			btn_start.Enabled = true;
			
		}
		
		void Btn_txtClick(object sender, EventArgs e)
		{
			if(mapeamento)
			{
				mapeamento = false;
			}
			string promptValue = ShowDialog("Informe um valor", "Texto");
			if(!string.IsNullOrEmpty(promptValue))
			{
				commands.Add(new Command { Type = "Text", Value = promptValue });
                listView1.Items.Add(new ListViewItem(new String[] { promptValue, etapa.ToString(), "Text"  }));
                etapa++;
                mapeamento = true;
                new Thread(new ThreadStart(Mapear)).Start();
			}
		}
		
		public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => {
            	prompt.Close();
            };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
		
		void Btn_ClearClick(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			commands.Clear();
			btn_start.Enabled = false;
			lbl_X.Text = "X:";
			lbl_y.Text = "Y:";
			etapa = 1;
		}
		
		void Btn_startClick(object sender, EventArgs e)
		{
			new Thread(new ThreadStart(StartProc)).Start();
		}
		
		const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        const int MOUSEEVENTF_LEFTUP = 0x0004;

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        
        private void StartProc()
        {
        	Invoke(new Del(strt));
        }
        
        void strt()
        {
        	foreach(var command in commands)
        	{
        		if(command.Type == "Click")
        		{
        		Cursor = new Cursor(Cursor.Current.Handle);
		        Thread.Sleep(1000);
		        Cursor.Position = command.Value;
		
		        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
		        Thread.Sleep(100);
		        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        		}
        		else
        		{
        			SendKeys.SendWait(command.Value);
        		}
        	}
        }
	}
}