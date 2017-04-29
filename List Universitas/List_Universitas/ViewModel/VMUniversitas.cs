using List_Universitas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace List_Universitas.ViewModel
{
    public class VMUniversitas: BindableObject
    {
        private List<ModelUniversitas> listUniversitas;
        public List<ModelUniversitas> ListUniversitas
        {
            get { return listUniversitas; }
            set
            {
                listUniversitas = value;
                OnPropertyChanged("ListItems");
            }
        }
        public VMUniversitas()
        {
            listUniversitas = new List<ModelUniversitas>
            {
                new ModelUniversitas {Gambar="UGM.gif",NamaUniversitas="UGM",Description="Universitas Gajdah Mada",Detail="Universitas Gadjah Mada, disingkat UGM, merupakan universitas negeri di Indonesia yang didirikan oleh Pemerintah Republik Indonesia pada tanggal 19 Desember 1949 berdasarkan Peraturan Pemerintah Nomor 23 Tahun 1949 tentang Peraturan Tentang Penggabungan Perguruan Tinggi Menjadi Universiteit tanggal 16 Desember 1949.Kampus UGM yang terletak di Yogyakarta tersebut merupakan universitas pertama yang didirikan oleh Pemerintah Republik Indonesia setelah Indonesia merdeka. \n Pada saat didirikan, Universitas Gadjah Mada hanya memiliki enam fakultas, sekarang memiliki 18 Fakultas dan dua Sekolah yaitu Sekolah Vokasi dan Sekolah Pascasarjana (dahulu bernama Program Pascasarjana), dan lebih dari 100 Program Studi untuk S-2,S-3, dan Spesialis. Universitas Gadjah Mada berlokasi di Kampus Bulaksumur Yogyakarta. Sebagian besar fakultas dalam lingkungan Universitas Gadjah Mada terdiri atas beberapa jurusan/bagian dan atau program studi. Kegiatan Universitas Gadjah Mada dituangkan dalam bentuk Tri Dharma Perguruan Tinggi yang terdiri atas Pendidikan dan Pengajaran, Penelitian dan Pengabdian kepada Masyarakat"},
                new ModelUniversitas {Gambar="UI.png",NamaUniversitas="UI",Description="Universitas Indonesia",Detail="Universitas Indonesia, biasa disingkat sebagai UI, adalah sebuah perguruan tinggi di Indonesia. Kampus utamanya terletak di bagian Utara dari Depok, Jawa Barat tepat di perbatasan antara Depok dengan wilayah Jakarta Selatan, dan kampus utama lainnya terdapat di daerah Salemba di Jakarta Pusat. Universitas Indonesia adalah kampus modern, komprehensif, terbuka, multi budaya, dan humanis yang mencakup disiplin ilmu yang luas. Telah menghasilkan lebih dari 400.000 alumni. Secara umum dianggap sebagai salah satu dari tiga perguruan tinggi papan atas di Indonesia bersama dengan Universitas Gadjah Mada dan Institut Teknologi Bandung."},
                new ModelUniversitas {Gambar="UNDIP.jpg",NamaUniversitas="UNDIP",Description="Universitas Diponegoro",Detail="Universitas Diponegoro,  disingkat Undip, adalah sebuah Perguruan Tinggi Negeri di Indonesia yang berlokasi di Semarang, Jawa Tengah, Indonesia. Undip didirikan pada tahun 1956 sebagai Perguruan Tinggi Swasta dan baru mendapat status sebagai Perguruan Tinggi Negeri pada tahun 1961. Kata Diponegoro diambil dari nama pahlawan nasional, yaitu Pangeran Diponegoro yang merupakan seorang pangeran pengobar semangat kemerdekaan dari tindakan kolonialisme Belanda di awal abad ke-18. Semangat ini turut menginspirasi pendirian Undip. Universitas Diponegoro memperoleh akreditasi A (Sangat Baik) dengan skor 361 dari Badan Akreditasi Nasional Perguruan Tinggi yang berlaku sejak 2013-2018. Berdasarkan Peraturan Pemerintah Nomor 52 Tahun 2015, Undip ditetapkan statusnya menjadi Perguruan Tinggi Negeri Badan Hukum."},
                new ModelUniversitas {Gambar="UNPAD.png",NamaUniversitas="UNPAD",Description="Universitas Padjadjaran",Detail="Universitas Padjadjaran (disingkat Unpad) adalah sebuah perguruan tinggi negeri di Bandung, Jawa Barat, Indonesia. \n Pada 20 Oktober 2014, Universitas ini berubah status menjadi Perguruan Tinggi Negeri Badan Hukum (PTN BH) dari Badan Layanan Umum (BLU). Peresmian itu ditandai dengan peraturan pemerintah (PP) yang ditandatangani mantan Presiden Susilo Bambang Yudhoyono. Penetapan itu didasarkan atas evaluasi kinerja yang dilakukan tim independen yang dibentuk Kementerian Pendidikan dan Kebudayan (Kemendikbud)[2]. Selain itu berdasarkan Keputusan Badan Akreditasi Nasional Perguruan Tinggi (BAN PT) yang ditetapkan pada 16 Januari 2014, Unpad mendapat peringkat A (sangat baik)."},
                new ModelUniversitas {Gambar="UPI.jpg",NamaUniversitas="UPI",Description="Universitas Pendidikan Indonesia",Detail="Universitas Pendidikan Indonesia (UPI) merupakan salah satu Perguruan Tinggi Negeri yang ada di Kota Bandung. \n   UPI juga termasuk sebagai salah satu kampus unggulan di Indonesia. Universitas Pendidikan Indonesia didirikan pada 20 Oktober 1954 yang mana sebelumnya bernama IKIP Bandung. \n Universitas Pendidikan Indonesia menawarkan 8 jenis Fakultas yaitu Fakultas Ilmu Pendidikan (FIP), Fakultas Pendidikan Bahasa dan Sastra (FPBS), Fakultas Pendidikan Matematika dan Ilmu Pengetahuan Alam (FPMIPA), Fakultas Pendidikan Ilmu Pengetahuan Sosial (FPIPS), Fakultas Pendidikan Olahraga dan Kesehatan (FPOK), Fakultas Pendidikan Teknologi dan Kejuruan (FPTK), Fakultas Pendidikan Seni dan Desain (FPSD) dan  Fakultas Pendidikan Ekonomi dan Bisnis (FPEB). Dengan banyaknya pilihan Fakultas yang ditawarkan, tidak heran jika banyak orang yang ingin melanjutkan pendidikan di Universitas yang berjuluk Kampus Bumi Siliwangi"}

            };
        }
    }
}
