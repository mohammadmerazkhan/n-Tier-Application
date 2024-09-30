using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
using DAL;  
using System.Data.SqlClient;  
using BAL.BE;  
using System.Data;  
namespace BAL.BL  
{  
    public class BusinessLogic  
    {  
        public bool EmpInfoinsert(BusinessEntities becat)  
      {  
            try  
            {  
                ConnectionFactory cf = new ConnectionFactory();  
                SqlParameter[] sp = new SqlParameter[10];  
                sp[0] = new SqlParameter("@Ename", becat.Ename);  
                sp[1] = new SqlParameter("@Designation", becat.Designation);  
                sp[2] = new SqlParameter("@Eimage", becat.Eimagename);  
                sp[3] = new SqlParameter("@Imagedata", becat.Imagedata);  
                sp[4] = new SqlParameter("@Salary", becat.Salary);  
                sp[5] = new SqlParameter("@Email", becat.Email);  
                sp[6] = new SqlParameter("@MobileNo", becat.MobileNo);  
                sp[7] = new SqlParameter("@Department", becat.Department);  
                sp[8] = new SqlParameter("@ManagerPost", becat.ManagerPost);  
                sp[9] = new SqlParameter("@Empno", becat.Empno);  
                return cf.InsertEmpInfo("spInsert_tblEmp", sp);  
            } catch  
            {  
                throw;  
            }  
        }  
        public bool EmpInfoupdate(BusinessEntities becat)  
            {  
            try {  
                ConnectionFactory cf = new ConnectionFactory();  
                SqlParameter[] sp = new SqlParameter[11];  
                sp[0] = new SqlParameter("@Eid", becat.Eid);  
                sp[1] = new SqlParameter("@Ename", becat.Ename);  
                sp[2] = new SqlParameter("@Designation", becat.Designation);  
                sp[3] = new SqlParameter("@Eimage", becat.Eimagename);  
                sp[4] = new SqlParameter("@Imagedata", becat.Imagedata);  
                sp[5] = new SqlParameter("@Salary", becat.Salary);  
                sp[6] = new SqlParameter("@Email", becat.Email);  
                sp[7] = new SqlParameter("@MobileNo", becat.MobileNo);  
                sp[8] = new SqlParameter("@Department", becat.Department);  
                sp[9] = new SqlParameter("@ManagerPost", becat.ManagerPost);  
                sp[10] = new SqlParameter("@Empno", becat.Empno);  
                return cf.InsertEmpInfo("spUpdate_tblEmp", sp);  
            } catch  
            {  
                throw;  
            }  
        }  
        public bool EmpInfoDelete(int Eid)   
            {  
            try  
            {  
                ConnectionFactory cf = new ConnectionFactory();  
                SqlParameter[] sp = new SqlParameter[1];  
                sp[0] = new SqlParameter("@Eid", Eid);  
                return cf.InsertEmpInfo("spDelete_tblEmp", sp);  
            } catch  
            {  
                throw;  
            }  
        }  
        public DataSet DisplayEmp()   
            {  
            ConnectionFactory cf = new ConnectionFactory();  
            DataSet ds = cf.DisplayEmpData("spdisplay_tblEmp");  
            return ds;  
        }  
        public DataSet DisplayEmpInfo(int Eid)  
        {  
            try  
            {  
                ConnectionFactory cf = new ConnectionFactory();  
                SqlParameter[] sp = new SqlParameter[1];  
                sp[0] = new SqlParameter("@Eid", Eid);  
                DataSet ds = cf.DisplayEmpData1("spdisplay_tblEmpdata", sp);  
                return ds;  
            } catch  
            {  
                throw;  
            }  
        }  
    }  
}  