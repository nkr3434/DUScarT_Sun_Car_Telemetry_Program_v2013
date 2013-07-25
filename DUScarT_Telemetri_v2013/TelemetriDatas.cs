/*
 Telemetriden Alınacak Veriler:
 ------------------------------
- Motor Akımı
- Motor Sıcaklığı
- Akü Akımı
- Akü Gerilimi
- Akü Sıcaklığı
- Aküde Kalan Enerji Miktarı
- Hız Göstergesi (Verisi Motor Sürücüsünden Alınacak)
- Max-Min Hız Sayacı
- Araba Konumunun Harita Üzerinde Gösterilmesi
- LAP Verisi
- MPPT Akımı
- MPPT Gerilimi (İptal Edilebilir)
- Panel Gerilimi (4 Adet)
- Panel Sıcaklığı (3 Adet)
- Sürücü Sıcaklığı
- Kokpid Sıcaklığı
 */

/*public int den
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DUScarT_Telemetri_v2013
{
    public class TelemetriDatas
    {
        private int HizMx;

        public TelemetriDatas()
        {
            MotorAkimi = 0;
            MotorSicakligi = 0;
            AkuAkimi = 0;
            AkuGerilimi = 0;
            AkuSicakligi = 0;
            AkudekiKalanEnerji = 0;
            Hiz = 0;
            HizMx = 0;
            KoordinatX = 0;
            KoordinatY = 0;
            LAPSayisi = 0;
            MPPTAkimi = 0;
            MPPTGerilimi = 0;
            PanelGerilim1 = 0;
            PanelGerilim2 = 0;
            PanelGerilim3 = 0;
            PanelGerilim4 = 0;
            PanelSicakligi1 = 0;
            PanelSicakligi2 = 0;
            PanelSicakligi3 = 0;
        }

        public int MotorAkimi { get; set; }
        public int MotorSicakligi { get; set; }
        public int AkuAkimi { get; set; }
        public int AkuGerilimi { get; set; }
        public int AkuSicakligi { get; set; }
        public int AkudekiKalanEnerji { get; set; }
        public int Hiz { get; set; }
        //public int HizMax { return HizMx; }
        public double KoordinatX { get; set; }
        public double KoordinatY { get; set; }
        public int LAPSayisi { get; set; }
        public int MPPTAkimi { get; set; }
        public int MPPTGerilimi { get; set; }
        public int PanelGerilim1 { get; set; }
        public int PanelGerilim2 { get; set; }
        public int PanelGerilim3 { get; set; }
        public int PanelGerilim4 { get; set; }
        public int PanelSicakligi1 { get; set; }
        public int PanelSicakligi2 { get; set; }
        public int PanelSicakligi3 { get; set; }
        public int SurucuSicakligi { get; set; }
        public int KokpidSicakligi { get; set; }
    }
}
