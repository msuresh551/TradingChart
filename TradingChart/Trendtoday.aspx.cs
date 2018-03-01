using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TradingChart
{
    public partial class Trendtoday : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindScripts();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "asdf", "CYIENT()", true);
            }
        }

        private void BindScripts()
        {
            try
            {
                BindCyient();
                BindInfy();
                BindJustDial();
                BindMindtree();
                BindWipro();
                BindWockPharma();
                BindDRREDDY();
                BindCipla();
                BindSunpharma();
                BindLupin();
            }
            catch (Exception ex)
            {
            }
        }

        private void BindLupin()
        {
            try
            {
                string result = "";
                int i = 0;
                bool read = false;
                //string url = "http://www.google.com/finance/getprices?q=LUPIN&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                //finance.google.com/finance
                string url = "http://finance.google.com/finance/getprices?q=LUPIN&x=NSE&i=1800&p=1d&f=o&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 7)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read && i != 19)
                    {
                        if (result == "")
                            result = str;
                        else
                            result = result + ',' + str;
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }

                }
                //closing
                url = "http://finance.google.com/finance/getprices?q=LUPIN&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                ver = response.ProtocolVersion.ToString();
                reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadLine();
                string lastvalue = "";
                while (str != null)
                {
                    lastvalue = str;
                    //Console.WriteLine(str);
                    str = reader.ReadLine();

                }
                //end
                txtLUPIN.Text = result + ',' + lastvalue;

            }
            catch (Exception ex)
            {
                
            }
        }

        private void BindSunpharma()
        {
            try
            {
                string result = "";
                int i = 0;
                bool read = false;
                string url = "http://finance.google.com/finance/getprices?q=SUNPHARMA&x=NSE&i=1800&p=1d&f=o&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 7)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read && i != 19)
                    {
                        if (result == "")
                            result = str;
                        else
                            result = result + ',' + str;
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }

                }
                //closing
                url = "http://finance.google.com/finance/getprices?q=SUNPHARMA&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                ver = response.ProtocolVersion.ToString();
                reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadLine();
                string lastvalue = "";
                while (str != null)
                {
                    lastvalue = str;
                    //Console.WriteLine(str);
                    str = reader.ReadLine();

                }
                //end
                txtSUNPHARMA.Text = result + ',' + lastvalue;

            }
            catch (Exception ex)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = "";
                int i = 0;
                bool read = false;
                string url = "http://finance.google.com/finance/getprices?q=CYIENT&x=NSE&i=1800&p=1d&f=o&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 7)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read && i != 19)
                    {
                        if (result == "")
                            result = str;
                        else
                            result = result + ',' + str;
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }

                }
                //closing
                url = "http://finance.google.com/finance/getprices?q=CYIENT&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                ver = response.ProtocolVersion.ToString();
                reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadLine();
                string lastvalue = "";
                while (str != null)
                {
                    lastvalue = str;
                    //Console.WriteLine(str);
                    str = reader.ReadLine();

                }
                //end
                //  TextBox1.Text = result + ',' + lastvalue;

                ScriptManager.RegisterStartupScript(this, this.GetType(), "asdf", "method1()", true);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void BindCyient()
        {
            try
            {
                string result = "";
                int i = 0;
                bool read = false;
                string url = "http://finance.google.com/finance/getprices?q=CYIENT&x=NSE&i=1800&p=1d&f=o&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 7)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        //Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read)
                    {
                        if (result == "")
                            result = str;
                        else
                            result = result + ',' + str;
                        //Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else
                    {
                        //Console.WriteLine(str);
                        str = reader.ReadLine();
                    }

                }
                //closing
                url = "http://finance.google.com/finance/getprices?q=CYIENT&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                ver = response.ProtocolVersion.ToString();
                reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadLine();
                string lastvalue = "";
                while (str != null)
                {
                    lastvalue = str;
                    //Console.WriteLine(str);
                    str = reader.ReadLine();

                }
                //end
                txtCyient.Text = result + ',' + lastvalue;


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void BindInfy()
        {
            try
            {
                string result = "";
                int i = 0;
                bool read = false;
                string url = "http://finance.google.com/finance/getprices?q=INFY&x=NSE&i=1800&p=1d&f=o&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 7)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read && i != 19)
                    {
                        if (result == "")
                            result = str;
                        else
                            result = result + ',' + str;
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }

                }
                //closing
                url = "http://finance.google.com/finance/getprices?q=INFY&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                ver = response.ProtocolVersion.ToString();
                reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadLine();
                string lastvalue = "";
                while (str != null)
                {
                    lastvalue = str;
                    //Console.WriteLine(str);
                    str = reader.ReadLine();

                }
                //end
                txtInfosys.Text = result + ',' + lastvalue;

                //   ScriptManager.RegisterStartupScript(this, this.GetType(), "infosys", "Infosys()", true);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void BindJustDial()
        {
            try
            {
                string result = "";
                int i = 0;
                bool read = false;
                string url = "http://finance.google.com/finance/getprices?q=JUSTDIAL&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 7)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read && i != 19)
                    {
                        if (result == "")
                            result = str;
                        else
                            result = result + ',' + str;
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }

                }
                //closing
                url = "http://finance.google.com/finance/getprices?q=JUSTDIAL&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                ver = response.ProtocolVersion.ToString();
                reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadLine();
                string lastvalue = "";
                while (str != null)
                {
                    lastvalue = str;
                    //Console.WriteLine(str);
                    str = reader.ReadLine();

                }
                //end
                txtJustDial.Text = result + ',' + lastvalue;

                //   ScriptManager.RegisterStartupScript(this, this.GetType(), "infosys", "Infosys()", true);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void BindMindtree()
        {
            try
            {
                string result = "";
                int i = 0;
                bool read = false;
                string url = "http://finance.google.com/finance/getprices?q=MINDTREE&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 7)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read && i != 19)
                    {
                        if (result == "")
                            result = str;
                        else
                            result = result + ',' + str;
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }

                }
                //closing
                url = "http://finance.google.com/finance/getprices?q=MINDTREE&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                ver = response.ProtocolVersion.ToString();
                reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadLine();
                string lastvalue = "";
                while (str != null)
                {
                    lastvalue = str;
                    //Console.WriteLine(str);
                    str = reader.ReadLine();

                }
                //end
                txtMindTree.Text = result + ',' + lastvalue;

                //   ScriptManager.RegisterStartupScript(this, this.GetType(), "infosys", "Infosys()", true);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void BindWipro()
        {
            try
            {
                string result = "";
                int i = 0;
                bool read = false;
                string url = "http://finance.google.com/finance/getprices?q=WIPRO&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 7)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read && i != 19)
                    {
                        if (result == "")
                            result = str;
                        else
                            result = result + ',' + str;
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }

                }
                //closing
                url = "http://finance.google.com/finance/getprices?q=WIPRO&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                ver = response.ProtocolVersion.ToString();
                reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadLine();
                string lastvalue = "";
                while (str != null)
                {
                    lastvalue = str;
                    //Console.WriteLine(str);
                    str = reader.ReadLine();

                }
                //end
                txtWipro.Text = result + ',' + lastvalue;


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void BindWockPharma()
        {
            try
            {
                string result = "";
                int i = 0;
                bool read = false;
                string url = "http://finance.google.com/finance/getprices?q=WOCKPHARMA&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 7)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read && i != 19)
                    {
                        if (result == "")
                            result = str;
                        else
                            result = result + ',' + str;
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }

                }
                //closing
                url = "http://finance.google.com/finance/getprices?q=WOCKPHARMA&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                ver = response.ProtocolVersion.ToString();
                reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadLine();
                string lastvalue = "";
                while (str != null)
                {
                    lastvalue = str;
                    //Console.WriteLine(str);
                    str = reader.ReadLine();

                }
                //end
                txtWockPharma.Text = result + ',' + lastvalue;

                //   ScriptManager.RegisterStartupScript(this, this.GetType(), "infosys", "Infosys()", true);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void BindDRREDDY()
        {
            try
            {
                string result = "";
                int i = 0;
                bool read = false;
                string url = "http://finance.google.com/finance/getprices?q=DRREDDY&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 7)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read && i != 19)
                    {
                        if (result == "")
                            result = str;
                        else
                            result = result + ',' + str;
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }

                }
                //closing
                url = "http://finance.google.com/finance/getprices?q=DRREDDY&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                ver = response.ProtocolVersion.ToString();
                reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadLine();
                string lastvalue = "";
                while (str != null)
                {
                    lastvalue = str;
                    //Console.WriteLine(str);
                    str = reader.ReadLine();

                }
                //end
                txtDRREDDY.Text = result + ',' + lastvalue;

                //   ScriptManager.RegisterStartupScript(this, this.GetType(), "infosys", "Infosys()", true);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void BindCipla()
        {
            try
            {
                string result = "";
                int i = 0;
                bool read = false;
                string url = "http://finance.google.com/finance/getprices?q=CIPLA&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 7)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read && i != 19)
                    {
                        if (result == "")
                            result = str;
                        else
                            result = result + ',' + str;
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }

                }
                //closing
                url = "http://finance.google.com/finance/getprices?q=CIPLA&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                ver = response.ProtocolVersion.ToString();
                reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadLine();
                string lastvalue = "";
                while (str != null)
                {
                    lastvalue = str;
                    //Console.WriteLine(str);
                    str = reader.ReadLine();

                }
                //end
                txtCipla.Text = result + ',' + lastvalue;

                //   ScriptManager.RegisterStartupScript(this, this.GetType(), "infosys", "Infosys()", true);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}