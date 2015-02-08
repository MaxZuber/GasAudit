using GasAudit.Dal.Abstract;
using GasAudit.Dal.Concrete;
using GasAudit.Entities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace GasAudit.DesktopUI
{
    public partial class MainWindow : Form
    {

        #region slider config
        private readonly int TRange = 3;        //діапазон зміни показів
        private readonly int FRange = 1;
        private readonly int PRange = 1;

        private int FBase = 33;                 //базове значення параметрів
        private int TBase = 67;
        private int PBase  = 8;

        #endregion slider config

        private Random random;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();        
        }

        private async void tmrSensor_Tick(object sender, EventArgs e)                   //подія таймера (500мс)
        {

            double TValue = (double)TBase + random.NextDouble() * (double)TRange;       //обраховуємо потчне значення параметра
            double FValue = (double)FBase + random.NextDouble() * (double)FRange;
            double PValue = (double)PBase + random.NextDouble() * (double)PRange;

            gasMnemo1.lblFIR.Text = FValue.ToString("0.000");                           //показуємо значення параметра
            gasMnemo1.lblPIR.Text = PValue.ToString("0.000");
            gasMnemo1.lblTIR.Text = TValue.ToString("0.000");

            tblGasTrends trend = new tblGasTrends()
                {
                    Flow = (decimal)FValue,
                    Preasure = (decimal)PValue,
                    Temperature = (decimal)TValue
                };

            using (var client = new HttpClient())                                       //використовуючи Web.Api записуємо дані в базу даних
            {
                client.BaseAddress = new Uri("http://gasaudit.gear.host/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.PostAsJsonAsync("api/GasAudit/insert", trend);

            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmrSensor.Start();                                                          //запуск опитування датчиків
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tmrSensor.Stop();                                                           //зупинка опитування датчиків
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            TBase = tbTIR.Value;                                                        //зміна базаового значення температури при прокручуванні трек-панелі
        }

        private void tbFIR_Scroll(object sender, EventArgs e)
        {
            FBase = tbFIR.Value;                                                        //зміна базаового значення витрати при прокручуванні трек-панелі
        }

        private void tbPIR_Scroll(object sender, EventArgs e)
        {
            PBase = tbPIR.Value;                                                        //зміна базаового значення тиску при прокручуванні трек-панелі
        }

        private void btnHideImitation_Click(object sender, EventArgs e)                 //показувати чи сховати панель імітації датчиків
        {
            if (gbWraper.Visible)
            {
                gbWraper.Hide();
                this.Height -= gbWraper.Height;
            }
            else
            {
                gbWraper.Show();
                this.Height += gbWraper.Height;
            }
            

        }
    }
}
