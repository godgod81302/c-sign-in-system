using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class signin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string myConnection = "datasource=localhost;username=root;password=";//準備好連線對象 


    protected void Button1_Click1(object sender, EventArgs e)
    {
        MySqlConnection myConn = new MySqlConnection(myConnection);
        MySqlCommand cmdDataBase = new MySqlCommand("select * from test.user where ID='" + this.textBoxID.Text + "'and Password='" + this.textBoxPw.Text + "';", myConn);
        MySqlDataReader myReader;
        myConn.Open();//打開連線
        myReader = cmdDataBase.ExecuteReader();
        int count = 0;
        while (myReader.Read())
        {
            string temp = myReader["ID"].ToString();
            string temp2 = myReader["Password"].ToString();
            Label4.Text = temp;
            Label5.Text = temp2;
            count = count + 1;
        }
        if (count == 1)
        {
            lblMsg.Text = "Login SUCESS";

        }
        else if (count > 1)
        {
            lblMsg.Text = "Login FAIL";
        }
        else
        {
            lblMsg.Text = "ID或密碼錯誤!-Wrong ID or Password!";

        }
        myConn.Close();
    }



    protected void textBoxID_TextChanged(object sender, EventArgs e)
    {

    }
}