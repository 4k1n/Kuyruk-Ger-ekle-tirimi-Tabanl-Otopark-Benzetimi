using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace YZM_2116_Proje1_Ödev1
{
    public partial class Form1 : Form
    {
        int size = 15;

        SimpleQueueOtopark sq;
        PriorityQueueOtopark pq;
        Random r;

        public Form1()
        {
            InitializeComponent();
            sq = new SimpleQueueOtopark(size);
            pq = new PriorityQueueOtopark(size);
            r = new Random();
        }



        public void SimpleQueue()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < size; i++)
            {
                Araba uye = sq._SimpleQueueOtopark[i];
                if (uye != null)
                {
                    string[] uyeStr = { uye.arabaNumara.ToString(), uye.Zaman.ToString() };
                    dataGridView1.Rows.Add(uyeStr);

                }
                else
                    continue;
            }

        }

        public void PriorityQueue()
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < size; i++)
            {
                Araba uye = pq._PriorityQueueOtopark[i];
                if (uye != null)
                {
                    string[] uyeStr = { uye.arabaNumara.ToString(), uye.Zaman.ToString() };
                    dataGridView2.Rows.Add(uyeStr);

                }
                else
                    continue;
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                Thread.Sleep(10);
                int zaman = r.Next(10, 301);
                int arabaNumara = r.Next(1, 51);

                Araba araba = new Araba(arabaNumara, zaman);

                sq.Insert(araba);
            }
            SimpleQueue();

        }

        private void btnSimpleRemove_Click(object sender, EventArgs e)
        {
            sq.Remove();
            SimpleQueue();
        }

        private void btnOrtZamanS_Click(object sender, EventArgs e)
        {
            int toplamZaman = 0;
            int tane = 0;

            foreach (Araba uye in sq._SimpleQueueOtopark)
            {
                if (uye != null)
                {
                    toplamZaman += uye.Zaman;
                    tane++;
                }
                else
                    continue;
            }
            MessageBox.Show("SimpleQueue için ortalama kalma süresi(sn): " + (toplamZaman / tane));
        }

        private void btnPriorityRemove_Click(object sender, EventArgs e)
        {
            pq.Remove();
            PriorityQueue();
        }

        private void btnOrtZamanP_Click(object sender, EventArgs e)
        {
            int toplamZaman = 0;
            int tane = 0;

            foreach (Araba uye in pq._PriorityQueueOtopark)
            {
                if (uye != null)
                {
                    toplamZaman += uye.Zaman;
                    tane++;
                }
                else
                    continue;
            }
            MessageBox.Show("PriorityQueue için ortalama kalma süresi(sn): " + (toplamZaman / tane));
        }

        private void btnSiralaP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                if (sq._SimpleQueueOtopark[i] != null)
                    pq.Insert(sq._SimpleQueueOtopark[i]);
                else
                    continue;
            }
            PriorityQueue();
        }
    }
}
