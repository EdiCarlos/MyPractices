using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections;

public delegate bool IECallBack(int hwnd, int lParam);

namespace RunningInstanceOfIE
{
	public class IEInstance : Form //Form is a class in System.Windows.Forms namespace
	{
			[DllImport("user32.Dll")]
			public static extern int EnumWindows(IECallBack x, int y); 
			[DllImport("User32.Dll")]
			public static extern void GetWindowText(int h, StringBuilder s, int nMaxCount);
			[DllImport("User32.Dll")]
			public static extern void GetClassName(int h, StringBuilder s, int nMaxCount);
			[DllImport("User32.Dll")]
			public static extern IntPtr PostMessage(IntPtr hWnd, int msg, int wParam, int lParam);
			
			private Button GetIE; //Button is a class in System.Windows.Forms namespace
			private Button RemoveIE; 
			private Label label1;//Label is a class in System.Windows.Forms namespace
			private ListBox listBox1; //ListBox is a class in System.Windows.Forms namespace
			private Container components = null;//Container is a class in System.ComponentModel namespace
			static IntPtr listBoxHandle;// IntPtr is a class in System namespace
			static IntPtr windowHandle;
			static StringBuilder sb, sbc;
			static int i =0;
			static ArrayList myAl;

		public IEInstance() //Constructor
		{
			InitializeComponent();
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
			this.GetIE = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.RemoveIE = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			
			// GetIE
			this.GetIE.Location = new System.Drawing.Point(40, 344);
			this.GetIE.Name = "GetIE";
			this.GetIE.TabIndex = 1;
			this.GetIE.Text = "GetIE";
			this.GetIE.Click += new System.EventHandler(this.GetIE_Click);
			
			// listBox1
			this.listBox1.Location = new System.Drawing.Point(24, 24);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(448, 251);
			this.listBox1.TabIndex = 0;
			this.listBox1.Click += new System.EventHandler(this.onlistBox_Select);
			 
			// RemoveIE
			this.RemoveIE.Enabled = false;
			this.RemoveIE.Location = new System.Drawing.Point(140, 344);
			this.RemoveIE.Name = "RemoveIE";
			this.RemoveIE.TabIndex = 2;
			this.RemoveIE.Text = "CloseIE";
			this.RemoveIE.Click += new System.EventHandler(this.RemoveIE_Click);
			
			// label1
			this.label1.Location = new System.Drawing.Point(32, 288);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Total Instances of Internet Explorer :";
						 
			// IEInstance
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(500, 400);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.label1,
																	  this.GetIE,
																	  this.RemoveIE,
																	  this.listBox1});
			this.Name = "IEInstance";
			this.Text = "Getting running instances of IE";
			this.ResumeLayout(false);
			myAl = new ArrayList();
		}
		#endregion

			private void GetIE_Click(object sender, System.EventArgs e)
			{
				listBoxHandle = listBox1.Handle;
				EnumWindows (new IECallBack(IEInstance.EnumWindowCallBack), (int)listBoxHandle) ;
				label1.Text = "Total Instances of Internet Explorer : "+i;
			}

		private static bool EnumWindowCallBack(int hwnd, int lParam) 
		{ 
			 windowHandle = (IntPtr)hwnd;
			 listBoxHandle = (IntPtr)lParam;
			ListBox lb =(ListBox)ListBox.FromHandle(listBoxHandle);
			sb = new StringBuilder(1024);
			sbc = new StringBuilder(256);
			GetClassName(hwnd,sbc,sbc.Capacity);
			GetWindowText((int)windowHandle, sb, sb.Capacity);
			
			String xMsg  = sb+" "+sbc+" "+windowHandle;
				if( sbc.Length > 0 )
				{
					if( sbc.ToString().Equals("IEFrame"))
					{
						myAl.Add(windowHandle);
						i++;
						lb.Items.Add(xMsg);	
					}
				}
			return true;
		}

				public static void Main() 
			{
				Application.Run(new IEInstance());
			}
		

			protected override void Dispose( bool disposing )
			{
				if( disposing )
				{
					if (components != null) 
					{
						components.Dispose();
					}
				}
				base.Dispose( disposing );
			}

			private void RemoveIE_Click(object sender, System.EventArgs e)
			{
					int index=listBox1.SelectedIndex;
					listBox1.Items.RemoveAt(index);
					int count =0;
					System.Collections.IEnumerator myEnumerator = myAl.GetEnumerator();
					while ( myEnumerator.MoveNext() )
					{
						if ( count == index )
						{
							listBoxHandle = (IntPtr)myEnumerator.Current;
							break;
						}
						count++;
					}
					PostMessage(listBoxHandle,0x0010/*WM_CLOSE*/,0,0);
					myAl.RemoveAt(count);
					i--;
					label1.Text = "Total Instances of Internet Explorer :" +i;
					RemoveIE.Enabled=false;
			}

			private void onlistBox_Select(object sender, System.EventArgs e)
			{
				RemoveIE.Enabled=true;
			}

		}
}
