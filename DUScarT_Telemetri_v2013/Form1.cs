using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUScarT_Telemetri_v2013
{
    public partial class MasterForm : Form
    {
        public static TelemetriDatas td = new TelemetriDatas();

        public MasterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ribbonPage1.Ribbon.Minimized = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(WaitForm1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }

        private void SanalVeriGondericideDegisikikYapildi(object sender, EventArgs e)
        {
            if (checkBox1.Checked) SanalVeriGontericiTimer.Enabled = true;
            else SanalVeriGontericiTimer.Enabled = false;
        }

        private void SanalVeriGontericiTimer_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                td.MotorAkimi = trackBarMotorAkimi.Value;
                td.MotorSicakligi = trackBarMotorSicakligi.Value;
                td.AkuAkimi = trackBarAkuAkimi.Value;
                td.AkuGerilimi = trackBarAkuGerilimi.Value;
                td.AkuSicakligi = trackBarAkuSicakligi.Value;
                td.AkudekiKalanEnerji = trackBarAkudekiKalanEnerji.Value;
                td.Hiz = trackBarHiz.Value;
                td.KoordinatX = trackBarKoordinatX.Value;
                td.KoordinatY = trackBarKoordinatY.Value;
                td.LAPSayisi = trackBarLapSayisi.Value;
                td.MPPTAkimi = trackBarMPPTAkimi.Value;
                td.MPPTGerilimi = trackBarMPPTGerilimi.Value;
                td.PanelGerilim1 = trackBarPanelGerilim1.Value;
                td.PanelGerilim2 = trackBarPanelGerilim2.Value;
                td.PanelGerilim3 = trackBarPanelGerilim3.Value;
                td.PanelGerilim4 = trackBarPanelGerilim4.Value;
                td.PanelSicakligi1 = trackBarPanelSicakligi1.Value;
                td.PanelSicakligi2 = trackBarPanelSicakligi2.Value;
                td.PanelSicakligi3 = trackBarPanelSicakligi3.Value;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sira = 0;
            for (int i = 1; i <= 20; i++)
            {
                sira = listViewAllDatas.Items.Count;
                listViewAllDatas.Items.Add("t1");
                listViewAllDatas.Items[sira].SubItems.Add("t2" + sira.ToString());
            }


            listViewAllDatas.EnsureVisible(sira);
            this.listViewAllDatas.Focus();
            this.listViewAllDatas.Items[sira].Selected = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }
    }
}
