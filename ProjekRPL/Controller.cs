using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekRPL
{
    class Controller
    {
        Model_User ml = new Model_User();
        Model_Post mp = new Model_Post();
        Model_Akun ma = new Model_Akun();

        //---USER----
        //Login
        public string getLogin(string username, string pass)
        {
            return ml.cekLogin(username, pass);
        }

        //Register
        public string getDataReg(string foto, string nama, DateTime tgl,
           string alamat, string email, string nope, string username, string password)
        {
            return ml.AddNewUser(foto, nama, tgl, alamat, email, nope, username, password);
        }



        //---POST----
        //Melihat seluruh list postingan
        static List<Image> listOfImages;
        static List<String> listofJudul;
        static List<String> listofDesk;
        static List<String> listofMember;
        static List<String> listofID;
        static List<String> listofUsername;

        public void getPostSelected()
        {
            listOfImages = mp.getlistImage();
            listofJudul = mp.getlistOfJudul();
            listofDesk = mp.getlistOfDesk();
            listofMember = mp.getlistOfMember();
            listofID = mp.getlistOfID();
            listofUsername = mp.getlistOfUsername();
        }

        public List<Image> getlistImage()
        {
            return listOfImages;
        }
        public List<String> getlistOfJudul()
        {
            return listofJudul;
        }
        public List<String> getlistOfDesk()
        {
            return listofDesk;
        }
        public List<String> getlistOfMember()
        {
            return listofMember;
        }
        public List<String> getlistOfID()
        {
            return listofID;
        }
        public List<String> getlistOfUsername()
        {
            return listofUsername;
        }

        //Buat post baru
        public string getNewPost(string judul, string deskripsi, string hasil_tani,
                               DateTime tgl_post, string foto, string stok, string lokasi, string provinsi,
                               string kota, string harga)
        {
            return mp.AddNewPost(judul, deskripsi, hasil_tani, tgl_post, foto, stok, lokasi, provinsi,
                                    kota, harga);
        }

        //Melihat detail post
        public ArrayList getPostDetail(string idpost)
        {
            return mp.findPostDetail(idpost);
        }

        //Melakukan order post
        public string getOrdered(string idakun, string idpost, string tgl)
        {
            return mp.findOrdered(idakun, idpost, tgl);
        }

        //Melakukan edit post
        public string getEdited(string judul, string deskripsi, string hasil_tani,
                                string foto, string stok, string lokasi, string provinsi,
                                string kota, string harga, string idpost)
        {
            return mp.ProcessEdited(judul, deskripsi, hasil_tani, foto, stok, lokasi, provinsi,
                                    kota, harga, idpost);
        }

        //Melakukan delete post
        public String getDeleted(string idpost)
        {
            return mp.ProcessDeleted(idpost);
        }

        //Melakukan validasi order post
        public String getValidation(string idorder)
        {
            return mp.OrderValidated(idorder);
        }



        //----AKUN----
        //Menghapus akun
        public String getAccountSelected(string idakun)
        {
            return ma.DeleteProcess(idakun);
        }

        //Melihat detail profil
        public ArrayList getMember(String username)
        {
            return ma.findMember(username);
        }
    }
}
