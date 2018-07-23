using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Trombino
{
    public partial class Form1
    {
        PictureBox[] box = new PictureBox[50];

        private void connexion()
        {
            string connetionString = null;
            connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                //label1.Text = "Connexion établie";
                SqlCommand requete = cnn.CreateCommand();
                requete.CommandText = "SELECT * FROM IDENTIFIANTS";
                SqlDataReader dataReader = requete.ExecuteReader();
                textBox1.Clear();
                int i;
                int j;
                
                string[] tab = new string[dataReader.FieldCount];

             
                    while (dataReader.Read())
                    {
                      
                        }

                

                dataReader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! ");
            }
        }

        private void AfficherLesImages()
        {
            {
                string connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True";
                List<ImageList> list = new List<ImageList>();
                SqlConnection sqlConn = new SqlConnection(connetionString);
                string dept = comboBox1.Text;
                
                    string query = String.Format(@"SELECT PHOTO FROM IDENTIFIANTS WHERE DEPARTEMENT=@dept ORDER BY NOM"); // on ne recupère que l'image
                    SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@dept", dept);
                    cmd.Connection.Open();

                    box[1] = pictureBox1;
                    box[2] = pictureBox2;
                    box[3] = pictureBox3;
                    box[4] = pictureBox4;
                    box[5] = pictureBox5;
                    box[6] = pictureBox6;
                    box[7] = pictureBox7;
                    box[8] = pictureBox8;
                    box[9] = pictureBox9;
                    box[10] = pictureBox10;
                    box[11] = pictureBox11;
                    box[12] = pictureBox12;
                    box[13] = pictureBox13;
                    box[14] = pictureBox14;
                    box[15] = pictureBox15;
                    box[16] = pictureBox16;
                    box[17] = pictureBox17;
                    box[18] = pictureBox18;
                    box[19] = pictureBox19;
                    box[20] = pictureBox20;
                    box[21] = pictureBox21;
                    box[22] = pictureBox22;
                    box[23] = pictureBox23;
                    box[24] = pictureBox24;
                    box[25] = pictureBox25;
                    box[26] = pictureBox26;
                    box[27] = pictureBox27;
                    box[28] = pictureBox28;
                    box[29] = pictureBox29;
                    box[30] = pictureBox30;
                    box[31] = pictureBox31;
                    box[32] = pictureBox32;
                    box[33] = pictureBox33;
                    box[34] = pictureBox34;
                    box[35] = pictureBox35;
                    box[36] = pictureBox36;
                    box[37] = pictureBox37;
                    box[38] = pictureBox38;
                    box[39] = pictureBox39;
                    box[40] = pictureBox40;
                    box[41] = pictureBox41;
                    box[42] = pictureBox42;
                    box[43] = pictureBox43;
                    box[44] = pictureBox44;
                    box[45] = pictureBox45;



                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        for (int j = 0; j <= 1;)
                        {
                            while (reader.Read())
                            {
                                j++;
                                ImageList _image = new ImageList();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    byte[] data = (byte[])reader[i];
                                    MemoryStream ms = new MemoryStream(data);
                                    Image image = new Bitmap(ms); // on converti en Bitmap pour récupérer une image
                                    box[j].Image = image; // affichage de l'image dans la PictureBox
                                    list.Add(_image);

                                }
                            }
                        }
                        reader.Close();
                        sqlConn.Close();

                        if (list.Count == 0)
                            label1.Text = "There are no pictures in the database.";
                        else
                            label1.Text = "ok";

                    }
                

            }
        }

        // -----------------------------------------------------------------------------------------------------------------------------------------------
        // -----------------------------------Methode afficher détails à partir d'une photo---------------------------------------------------------------
        // -----------------------------------------------------------------------------------------------------------------------------------------------

        private void AfficherDetails(int p)
        {

            string connetionString = null;
            connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            byte[] code = imageToByteArray(box[p].Image);
            int Id = 1;

            
                cnn.Open();
                //label1.Text = "Connexion établie";

                SqlCommand requete = cnn.CreateCommand();
                requete.CommandText = "SELECT NOM FROM IDENTIFIANTS WHERE PHOTO=@PHOTO";
                requete.Parameters.Add(new SqlParameter("@PHOTO", code)); // récupération du parametre à afficher
                textBox1.Clear();

                SqlDataReader dataReader = requete.ExecuteReader();
               
                while (dataReader.Read())
                {

                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        //boutons.Add(new RadioButton());
                        string[] tab = new string[dataReader.FieldCount];
                        tab[i] = dataReader.GetValue(i).ToString(); //récupération du résultat dans un tableau avant de le retourner
                        textBox1.Text = textBox1.Text + tab[i] + Environment.NewLine;
                    }
                }

                dataReader.Close();
                cnn.Close();
            
        }


        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }


}


