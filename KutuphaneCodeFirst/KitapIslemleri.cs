﻿using KutuphaneCodeFirst.Entities;
using KutuphaneCodeFirst.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;
using KutuphaneCodeFirst.MockData;

namespace KutuphaneCodeFirst
{
    public partial class KitapIslemleri : Form
    {
        public KitapIslemleri()
        {
            InitializeComponent();
        }
       
        private void KitapIslemleri_Load(object sender, EventArgs e)
        {
            cmbYazar.DataSource = Mock.Yazarlar;
            lstKitaplar.DataSource = Mock.Kitaplar;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seciliKitap = (KitapViewModel)lstKitaplar.SelectedItem;
            //seciliYazar = (from o in Mock.Kitaplar
            //             where o.YazarId == seciliKitap.YazarId
            //             select o.Yazar) as Yazar;
            //txtKitapAdi.Text = seciliKitap.KitapAdi;
            //txtKategori.Text = seciliKitap.Kategori;
            //cmbYazar.SelectedItem = seciliYazar;
            //nuAdet.Value = seciliKitap.Adet;

            
        }

        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {
            var yazar = cmbYazar.SelectedItem as Yazar;
            if (yazar == null) return;
           
            var kitap = new Kitap
            {
                KitapAdi = txtKitapAdi.Text,
                Adet = Int32.Parse(txtAdet.Text),
                Kategori = txtKategori.Text,
                YazarId = yazar.YazarId,
            };
           var adet = KitapHelper.KitapEkle(kitap);
           MessageBox.Show($@"{adet} adet Kitap eklendi.");
        }
    }
}