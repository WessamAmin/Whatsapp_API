using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Whatsapp_API.Models;

namespace Whatsapp_API
{
    public partial class Send_Message : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }
      

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Class2.Root cr = new Class2.Root();
            Class2.Component cc = new Class2.Component();
            Class2.Component cc2 = new Class2.Component();
            Class2.Document cd = new Class2.Document();
            Class2.Parameter cp = new Class2.Parameter();
            Class2.Parameter cp2 = new Class2.Parameter();
            Class2.Language cl = new Class2.Language();
            Class2.Template ct = new Class2.Template();
            List<Class2.Component> lc = new List<Class2.Component>();
            List<Class2.Parameter> parameterslist = new List<Class2.Parameter>();
            List<Class2.Parameter> parameterslist2 = new List<Class2.Parameter>();






            //adding document
            cd.filename = TextBox4.Text;
            cd.link = TextBox2.Text;
          

            //adding parameters 

            parameterslist = new List<Class2.Parameter>()
            {
             new Class2.Parameter{type="document",document=new Class2.Document{ filename=cd.filename,link=cd.link } },


            };
            parameterslist2 = new List<Class2.Parameter>()
            {

            new Class2.Parameter { type = "text", text = TextBox3.Text }


            };


            //adding component

            lc = new List<Class2.Component>()
            {
          new Class2.Component{type="header",parameters = parameterslist},
           new Class2.Component{type="body",parameters = parameterslist2},

            };

            //adding language

            cl.code = "AR";
            cl.policy = "deterministic";

            //adding templet
            ct.components = lc;
            ct.language = cl;
            ct.name = "invoice";


            Class2.Root c1 = new Class2.Root();
            c1.to = TextBox1.Text;
                //"966500671471";
            c1.type = "template";
            c1.messaging_product = "whatsapp";
            c1.template = ct;

            var clientHandler = new HttpClientHandler();
            using (var client = new HttpClient(clientHandler))
            {

                client.DefaultRequestHeaders.Authorization =
      new AuthenticationHeaderValue("Bearer", "EAATOPOVlLg4BALBZC7khmfLbuLzaXmG4AVQor2J7eLZBXasScyFex6tOVIZACr9VczLOW20WsX3zdNFtCxivHQJEUcOMAl59IkIJJRl2J4QkB82QmjHeAoH465remgkbnpfJIIondz2PcSWAkgZBQPs6b8G2ZCckHqxGbQdhWtNz4ZCsIrna9A");
                var uri = new Uri("https://graph.facebook.com/v15.0/106531405690289/messages");
                var json = new JavaScriptSerializer().Serialize(c1);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PostAsync(uri, stringContent).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Successfully Send ");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                }
                else
                {
                    MessageBox.Show("Faild to send data");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                }
            }



      
        }
    }
}