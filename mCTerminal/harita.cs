using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mCTerminal
{
    public partial class harita : Form
    {
        public harita()
        {
            InitializeComponent();
            
        }

        private void üstteGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Üstte göster - gösterme butonu için
            if (this.TopMost == true)
            {
                üstteGösterToolStripMenuItem.CheckState = CheckState.Unchecked;
                this.TopMost = false;
            }
            else
            {
                üstteGösterToolStripMenuItem.CheckState = CheckState.Checked;
                this.TopMost = true;

            }

        }

        private void tamEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tam Ekran - Küçük Ekran butonu
            if (this.FormBorderStyle == FormBorderStyle.Sizable)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                tamEkranToolStripMenuItem.Text = "Küçültülmüş Ekran";
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                tamEkranToolStripMenuItem.Text = "Tam Ekran";
            }
            

        }

        private void harita_Load(object sender, EventArgs e)
        {
            harita1.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            harita1.Position = new GMap.NET.PointLatLng(39.9179769, 44.0351519);
            harita1.Zoom = 10;

        }
        private void bingHaritaToolStripMenuItem_Click(object sender, EventArgs e) //HARİTA SAĞLAYICISINI BING İLE DEĞİŞTİR
        {
            harita1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            harita1.ReloadMap();
        }

        private void wikiMapiaToolStripMenuItem_Click(object sender, EventArgs e) //HARİTA SAĞLAYICISINI WİKİMAPİA YAP
        {
            harita1.MapProvider = GMap.NET.MapProviders.WikiMapiaMapProvider.Instance;
            harita1.ReloadMap();
        }

        private void turkeyMapProviderToolStripMenuItem_Click(object sender, EventArgs e) //Bu çalışmıyor ama Türkiye dediği için bırakıyorum, Easter Egg gibi düşünün siz.
        {
            harita1.MapProvider = GMap.NET.MapProviders.TurkeyMapProvider.Instance;
            harita1.ReloadMap();
        }

        private void uyduHaritasıToolStripMenuItem_Click(object sender, EventArgs e) //HARİTA SAĞLAYICISINI GOOGLE UYDU GÖRÜNTÜSÜ YAP
        {
            harita1.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
            harita1.ReloadMap();
        }

        private void şehirHaritasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            harita1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            harita1.ReloadMap();
        }

        private void araziHaritasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            harita1.MapProvider = GMap.NET.MapProviders.GoogleTerrainMapProvider.Instance;
            harita1.ReloadMap();
        }
        //------------------HARİTA KONUMUNA GÖRE TEXTBOXLARI DEĞİŞTİR---------------------
        private void harita1_OnPositionChanged(GMap.NET.PointLatLng point)
        {
            enlemTextBox.Text = harita1.Position.Lat.ToString();
            boylamTextBox.Text = harita1.Position.Lng.ToString();
        }

        private void harita1_OnMapZoomChanged()
        {
            enlemTextBox.Text = harita1.Position.Lat.ToString();
            boylamTextBox.Text = harita1.Position.Lng.ToString();
        }

        private void gitButon_Click(object sender, EventArgs e)
        {
            double enlem = Convert.ToDouble(enlemTextBox.Text);
            double boylam = Convert.ToDouble(boylamTextBox.Text);
            harita1.Position = new GMap.NET.PointLatLng(enlem, boylam);
        }

        private void haritaRoketEsle_Tick(object sender, EventArgs e) 
        {
            if (haritaortala_checkbox.CheckState == CheckState.Checked) //eğer haritayı ortala seçeneğine tik atılmışsa
            {
                //önce enlem ve boylam adında değişkenler oluşturuyoruz ve bu değişkenlerdeki "." karakterini ";" ile değiştiriyoruz
                //çünkü haritamız nokta (".") ile belirtilen koordinatlara gidemiyor, virgül (",") ile belirtilmesi lazım
                string enlem = mCTerminal.Properties.Settings.Default.enlem.Replace(".", ",");
                string boylam = mCTerminal.Properties.Settings.Default.boylam.Replace(".", ",");
                //şimdi ise string formatındaki koordinat bilgilerimizi double formatına çevirip haritada göstertiyoruz.
                try
                {
                    harita1.Position = new GMap.NET.PointLatLng(Convert.ToDouble(enlem), Convert.ToDouble(boylam));
                }
                catch
                { 
                }

                
            }
            
        }

        private void harita_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
