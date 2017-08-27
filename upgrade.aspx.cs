using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
public partial class upgrade : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string con = "datasource=localhost;username=root;password=";

            string Query = "UPDATE test.user  SET Pw = '" + this.TextBox2.Text + "' WHERE ID='" + this.TextBox1.Text + "'";
            MySqlConnection Database = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(Query, Database);
            Database.Open();
            if (TextBox2.Text == "" || TextBox2.Text == "")
            {
                Label3.Text = "資料輸入錯誤!";
            }
            else
            {
                MySqlDataReader myreader;
                myreader = cmd.ExecuteReader();
                Label3.Text = "成功修改!";

                TextBox2.Text = TextBox1.Text = "";
                myreader.Close();

            }
        }
        catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
        }
    }
}