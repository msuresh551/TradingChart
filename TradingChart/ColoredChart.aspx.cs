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
    public partial class ColoredChart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
                bindscripts();
        }

        private void bindscripts()
        {
            try
            {
                // string[] MyArray = new string[] { "	TATAMOTORS	", "	HEROMOTOCO	", "	ASIANPAINT	", "	INDUSINDBK	", "	AUROPHARMA	", "	TATAMTRDVR	", "	CIPLA	", "	DRREDDY	", "	HCLTECH	", "	ZEEL	", "	AXISBANK	", "	MARUTI	", "	YESBANK	", "	WIPRO	", "	AMBUJACEM	", "	INFY	", "	ULTRACEMCO	", "	POWERGRID	", "	NTPC	", "	BPCL	", "	HINDUNILVR	", "	BOSCHLTD	", "	TCS	", "	TATASTEEL	", "	SUNPHARMA	", "	M&M	", "	HDFC	", "	TECHM	", "	ACC	", "	BAJAJ-AUTO	", "	ITC	", "	GRASIM	", "	HINDALCO	", "	TATAPOWER	", "	KOTAKBANK	", "	EICHERMOT	", "	SBIN	", "	HDFCBANK	", "	RELIANCE	", "	ICICIBANK	", "	COALINDIA	", "	LT	", "	ONGC	", "	INFRATEL	", "	LUPIN	", "	ADANIPORTS	", "	BHEL	", "	BANKBARODA	", "	BHARTIARTL	", "	GAIL	", "	IDEA	", };
                string[] strScripts = new string[] { "	ACC	", "	ADANIPORTS	", "	AMBUJACEM	", "	ASIANPAINT	", "ASHOKLEY", "	AUROPHARMA	", "	AXISBANK	", "	BAJAJ-AUTO	", "	BANKBARODA	", "	BHARTIARTL	", "	BHEL	", "	BOSCHLTD	", "	BPCL	", "	CIPLA	", "	COALINDIA	", "	DRREDDY	", "	EICHERMOT	", "	GAIL	", "	GRASIM	", "	HCLTECH	", "	HDFC	", "	HDFCBANK	", "	HEROMOTOCO	", "	HINDALCO	", "	HINDUNILVR	", "	ICICIBANK	", "	IDEA	", "	INDUSINDBK	", "	INFRATEL	", "	INFY	", "	ITC	", "	KOTAKBANK	", "	LT	", "	LUPIN	", "	M&M	", "	MARUTI	", "	NTPC	", "	ONGC	", "	POWERGRID	", "	RELIANCE	", "	SBIN	", "	SUNPHARMA	", "	TATAMOTORS	", "	TATAPOWER	", "	TATASTEEL	", "	TCS	", "	TECHM	", "	ULTRACEMCO	", "	WIPRO	", "	YESBANK	", "	ZEEL	" };
                string[] strScriptNames = new string[] { "	ACC Ltd.	", "	Adani Ports And Special Economic Zone Ltd.	", "	Ambuja Cements Ltd.	", "	Asian Paints Ltd.	", "Ashok Leyland Ltd", "Aurobindo Pharma Ltd", "	Axis Bank Ltd.	", "	Bajaj Auto Ltd.	", "	Bank Of Baroda	", "	Bharti Airtel Limited	", "	Bharat Heavy Electricals Limited	", "	Bosch Ltd	", "	Bharat Petroleum Corporation Ltd.	", "	Cipla Ltd.	", "	Coal India Ltd.	", "	Dr. Reddy's Laboratories Ltd.	", "	Eicher Motors Ltd	", "	GAIL (India) Ltd.	", "	Grasim Industries Ltd	", "	HCL Technologies Ltd.	", "	Housing Development Finance Corporation Ltd.	", "	HDFC Bank Ltd.	", "	Hero Motocorp Ltd.	", "	Hindalco Industries Ltd.	", "	Hindustan Unilever Ltd.	", "	ICICI Bank Ltd.	", "	Idea Cellular Ltd.	", "	Indusind Bank Ltd.	", "	Bharti Infratel Ltd	", "	Infosys Ltd.	", "	ITC Ltd.	", "	Kotak Mahindra Bank Ltd.	", "	Larsen & Toubro Ltd.	", "	Lupin Ltd.	", "	Mahindra & Mahindra Ltd.	", "	Maruti Suzuki India Ltd.	", "	NTPC Limited	", "	Oil & Natural Gas Corporation Ltd.	", "	Power Grid Corporation Of India Ltd.	", "	Reliance Industries Ltd.	", "	State Bank Of India	", "	Sun Pharmaceutical Industries Ltd.	", "	Tata Motors Ltd.	", "	Tata Power Company Limited	", "	Tata Steel Limited	", "	Tata Consultancy Services Limited	", "	Tech Mahindra Ltd	", "	Ultratech Cement Ltd.	", "	Wipro Ltd.	", "	Yes Bank Ltd.	", "	Zee Entertainment Enterprises Ltd.	" };

                DataTable dt = new DataTable();
                dt.Columns.Add("strScripts", typeof(string));

                dt.Columns.Add("strScriptNames", typeof(string));
                for (int i = 0; i < strScriptNames.Length; i++)
                {
                    dt.Rows.Add(strScripts[i], strScriptNames[i]);
                }
                dt.AcceptChanges();
                ddlscript.DataSource = dt;
                ddlscript.DataTextField = "strScriptNames";
                ddlscript.DataValueField = "strScripts";
                ddlscript.DataBind();
            }
            catch (Exception ex)
            {
            }
        }
        protected void ddlscript_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtScriptID.Text = ddlscript.SelectedItem.Text.Trim();
                string result = "";
                int i = 0;
                bool read = false;
                string url = "http://www.google.com/finance/getprices?q=" + ddlscript.SelectedValue.Trim() + "&x=NSE&i=1800&p=2d&f=o&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 21)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read)
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
                url = "http://www.google.com/finance/getprices?q=" + ddlscript.SelectedValue.Trim() + "&x=NSE&i=1800&p=2d&f=o&df=cpct&auto=1&ts=1266701290218";
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
                TextBox1.Text = result + ',' + lastvalue;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "asdf", "method1()", true);

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
                string url = "http://www.google.com/finance/getprices?q=" + txtScriptID.Text.ToUpper().ToString().Trim() + "&x=NSE&i=1800&p=2d&f=c&df=cpct&auto=1&ts=1266701290218";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String ver = response.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadLine();
                while (str != null)
                {
                    i++;
                    if (i == 20)
                        read = true;
                    if (str == "TIMEZONE_OFFSET=330")
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    else if (read)
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
                url = "http://www.google.com/finance/getprices?q=" + txtScriptID.Text.Trim() + "&x=NSE&i=1800&p=1d&f=c&df=cpct&auto=1&ts=1266701290218";
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
                TextBox1.Text = result;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "asdf", "method1()", true);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}