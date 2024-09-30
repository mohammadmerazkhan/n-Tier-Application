using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BAL.BE;
using BAL.BL;
using System.Data;
using System.IO;
public partial class PAGE_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindGridViewData();
        txteid.Visible = false;
    }
    public void BindGridViewData()
    {
        BusinessLogic beobj = new BusinessLogic();
        DataSet ds = beobj.DisplayEmp();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    //insert button code  
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (fileUpload1.HasFile)
        {
            int length = fileUpload1.PostedFile.ContentLength;
            byte[] imgbyte = new byte[length];
            HttpPostedFile img = fileUpload1.PostedFile;
            //set the binary data  
            img.InputStream.Read(imgbyte, 0, length);
            string filename = Path.GetFileName(fileUpload1.PostedFile.FileName);
            BusinessEntities be = new BusinessEntities();
            BusinessLogic bl = new BusinessLogic();
            be.Ename = txtename.Text;
            be.Designation = txtdesg.Text;
            //be.Eimage=txtimage.  
            be.Eimagename = filename;
            be.Imagedata = imgbyte;
            be.Salary = txtsalary.Text;
            be.Email = txtEmail.Text;
            be.MobileNo = txtmob.Text;
            be.Department = txtdept.Text;
            be.ManagerPost = txtpost.Text;
            be.Empno = txtempno.Text;
            bool result = bl.EmpInfoinsert(be);
            lblmsg.Text = "Record saved successfully.....";
            BindGridViewData();
            txteid.Text = txtename.Text = txtdept.Text = txtdesg.Text = txtempno.Text = txtsalary.Text = txtpost.Text = txtmob.Text = txtEmail.Text = "";
        }
    }
    //update button code  
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        txteid.Visible = true;
        //BindGridViewData1();  
        if (fileUpload1.HasFile)
        {
            int length = fileUpload1.PostedFile.ContentLength;
            byte[] imgbyte = new byte[length];
            HttpPostedFile img = fileUpload1.PostedFile;
            //set the binary data  
            img.InputStream.Read(imgbyte, 0, length);
            string filename = Path.GetFileName(fileUpload1.PostedFile.FileName);
            BusinessEntities be = new BusinessEntities();
            BusinessLogic bl = new BusinessLogic();
            be.Eid = int.Parse(txteid.Text);
            be.Ename = txtename.Text;
            be.Designation = txtdesg.Text;
            //be.Eimage=txtimage.  
            be.Eimagename = filename;
            be.Imagedata = imgbyte;
            be.Salary = txtsalary.Text;
            be.Email = txtEmail.Text;
            be.MobileNo = txtmob.Text;
            be.Department = txtdept.Text;
            be.ManagerPost = txtpost.Text;
            be.Empno = txtempno.Text;
            bool result = bl.EmpInfoupdate(be);
            lblmsg.Text = "Record updated successfully.....";
            BindGridViewData();
            txteid.Text = txtename.Text = txtdept.Text = txtdesg.Text = txtempno.Text = txtsalary.Text = txtpost.Text = txtmob.Text = txtEmail.Text = "";
            txteid.Visible = false;
        }
    }
    //resete button code  
    protected void btnresete_Click(object sender, EventArgs e)
    {
        txteid.Text = txtename.Text = txtdept.Text = txtdesg.Text = txtempno.Text = txtsalary.Text = txtpost.Text = txtmob.Text = txtEmail.Text = "";
    }
    //display on particular record in textbox code  
    protected void Button1_Click(object sender, EventArgs e)
    {
        txteid.Visible = true;
        Button btn = (Button)sender;
        string CommandName = btn.CommandName;
        string CommandArgument = btn.CommandArgument;
        int abcd = int.Parse(CommandArgument);
        BindGridViewData1(abcd);
    }
    //display record code  
    private void BindGridViewData1(int abcd)
    {
        BusinessLogic beobj = new BusinessLogic();
        DataSet ds = beobj.DisplayEmpInfo(abcd);
        int emid = (int)ds.Tables[0].Rows[0][0];
        txteid.Text = emid.ToString();
        txtename.Text = ds.Tables[0].Rows[0][1].ToString();
        txtdesg.Text = ds.Tables[0].Rows[0][2].ToString();
        txtsalary.Text = ds.Tables[0].Rows[0][5].ToString();
        txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
        txtmob.Text = ds.Tables[0].Rows[0][7].ToString();
        txtdept.Text = ds.Tables[0].Rows[0][8].ToString();
        txtpost.Text = ds.Tables[0].Rows[0][9].ToString();
        txtempno.Text = ds.Tables[0].Rows[0][10].ToString();
    }
    //In gridview delete button code  
    protected void Button2_Click(object sender, EventArgs e)
    {
        txteid.Visible = true;
        Button btn = (Button)sender;
        string CommandName = btn.CommandName;
        string CommandArgument = btn.CommandArgument;
        int xyz = int.Parse(CommandArgument);
        BusinessEntities be = new BusinessEntities();
        BusinessLogic bl = new BusinessLogic();
        bool res = bl.EmpInfoDelete(xyz);
    }

   
}