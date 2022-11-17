using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Net.Sockets;


namespace WindowsFormsApp1
{
    public partial class Forms1 : Form
    {
        public Forms1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                var service = ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == txtServiceName.Text);
                if (service == null)
                    lblResultSrv1.Text = $"Service {txtServiceName.Text} not found!";
                else
                    lblResultSrv1.Text = $"Service {txtServiceName.Text} is {service.Status}";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                using (var client = new TcpClient())
                {
                    var result = client.BeginConnect(txtDBserver.Text, int.Parse(txtDBport.Text), null, null);
                    var success = result.AsyncWaitHandle.WaitOne(30000);
                    client.EndConnect(result);


                }
            }
            catch (Exception ex) { lblResult.Text = ex.ToString(); }
        }

        private void txtDBserver_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
