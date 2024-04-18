using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadRecord();
        }
    }
    SqlConnection con = new SqlConnection(@"Data Source=CHN-0368\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand com = new SqlCommand("Insert into Employee values('"+int.Parse(TextBox1.Text) +"','"+TextBox2.Text+"','"+ DropDownList1.SelectedValue+ "','"+ TextBox4.Text + "')",con);
        com.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Employee Successfully Added')", true);
        LoadRecord();
    }

    void LoadRecord()
    {
        SqlCommand com = new SqlCommand("SELECT * FROM Employee", con);
        SqlDataAdapter d = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        d.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand com = new SqlCommand("UPDATE Employee SET Name='"+ TextBox2.Text + "',Address='" + DropDownList1.SelectedValue + "',Contact='" + TextBox4.Text + "' WHERE Id='"+int.Parse(TextBox1.Text)+"'", con);
        com.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Employee Successfully Updated')", true);
        LoadRecord();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand com = new SqlCommand("DELETE FROM Employee WHERE Id='"+int.Parse(TextBox1.Text)+"'", con);
        com.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Employee Successfully Deleted')", true);
        LoadRecord();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        
        SqlCommand com = new SqlCommand("SELECT * FROM Employee WHERE Name LIKE '"+TextBox2.Text+"%'", con);
        con.Open();
        com.ExecuteNonQuery();
        SqlDataAdapter d = new SqlDataAdapter(com);
        con.Close();
        DataTable dt = new DataTable();
        d.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}