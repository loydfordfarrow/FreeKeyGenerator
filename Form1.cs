using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Reflection.Emit;
using System.Web.UI.WebControls;
using System.Net;

namespace FreeKeyGenerator
{
    public partial class Form1 : Form
    {
        public string url = "view-source:https://fer3onhax.com/free/";
        public int 
              count1 = 7
            , count2 = 7
            , count3 = 7
            , count4 = 7
            , count5 = 7
            , count6 = 7
            , count7 = 5400
            , count8 = 5400
        ;

        public Form1()
        {
            InitializeComponent();

            url = "https://fer3onhax.com/free/";
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(url);
            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }

            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count1--;
            if (count1 == 0)
            {
                timer1.Stop();
                System.Diagnostics.Debug.WriteLine("count1");

                webBrowser1.Navigate(url);
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }

                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer2_Tick);
                timer1.Interval = 1000;
                timer1.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count2--;
            if (count2 == 0)
            {
                timer1.Stop();
                System.Diagnostics.Debug.WriteLine("count2");

                webBrowser1.Navigate(url);
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }

                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer3_Tick);
                timer1.Interval = 1000;
                timer1.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            count3--;
            if (count3 == 0)
            {
                timer1.Stop();
                System.Diagnostics.Debug.WriteLine("count3");

                webBrowser1.Navigate(url);
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }

                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer4_Tick);
                timer1.Interval = 1000;
                timer1.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            count4--;
            if (count4 == 0)
            {
                timer1.Stop();
                System.Diagnostics.Debug.WriteLine("count4");

                webBrowser1.Navigate(url);
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }

                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer5_Tick);
                timer1.Interval = 1000;
                timer1.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            count5--;
            if (count5 == 0)
            {
                timer1.Stop();
                System.Diagnostics.Debug.WriteLine("count5");

                webBrowser1.Navigate(url);
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }

                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer6_Tick);
                timer1.Interval = 1000;
                timer1.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            count6--;
            if (count6 == 0)
            {
                timer1.Stop();
                System.Diagnostics.Debug.WriteLine("count6");

                webBrowser1.Navigate(url);
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }


                try{
                    String[] strlist = webBrowser1.Document.Body.InnerText.Split(new string[] { "FREE" }, StringSplitOptions.None);
                    var tmp = strlist[1];
                    strlist = tmp.Split(new string[] { "2h" }, StringSplitOptions.None);
                    tmp = strlist[0];
                    strlist = tmp.Split(new string[] { "\r\n\r\n" }, StringSplitOptions.None);
                    tmp = strlist[0];
                    tmp = "FREE" + tmp;
                    var request = (HttpWebRequest)WebRequest.Create("https://connect.api.com.ph/it/addkey?key=" + tmp);
                    var response = (HttpWebResponse)request.GetResponse();
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                }catch(Exception ex) {
                    Application.Restart();
                }
                
                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer7_Tick);
                timer1.Interval = 1000;
                timer1.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            count7--;
            if (count7 == 0)
            {
                timer1.Stop();
                System.Diagnostics.Debug.WriteLine("count7");

                Application.Restart();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            count8--;
            if (count8 == 0)
            {
                timer1.Stop();
                System.Diagnostics.Debug.WriteLine("count8");

                // EXIT 
                Application.Exit();
            }
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
        }

    }
}
