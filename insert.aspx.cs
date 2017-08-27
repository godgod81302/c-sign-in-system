using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         try
            {
                string con = "datasource=localhost;username=root;password=";
                string Query = "insert into test.user(Pw,ID)values('" + this.TextBox2.Text + "','" + this.TextBox1.Text + "');";
                MySqlConnection Database = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(Query, Database);
                Database.Open();
                if (TextBox2.Text == "" || TextBox2.Text == "")
                {
                   Label3.Text="資料輸入錯誤!";
                }
                else
                {
                    MySqlDataReader myreader;
                    myreader = cmd.ExecuteReader();
                    Label3.Text = "成功新增!";
                  
                    TextBox2.Text = TextBox1.Text = "";
                    myreader.Close();

                }
            }
         catch (MySql.Data.MySqlClient.MySqlException ex)
         {
             Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
         }


    }
 




    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {
        
        string con = "datasource=localhost;username=root;password=";
        string Query = "select * from test.user where ID='" + this.TextBox1.Text + "';";
        MySqlConnection Database = new MySqlConnection(con);
        MySqlCommand cmd = new MySqlCommand(Query, Database);
        Database.Open();
        MySqlDataReader myreader;
        myreader = cmd.ExecuteReader();
        while (myreader.Read())
        {
            string temp = myreader["ID"].ToString();

            Label4.Text = "此帳號已經被註冊，請從新輸入";
        }
    }
}