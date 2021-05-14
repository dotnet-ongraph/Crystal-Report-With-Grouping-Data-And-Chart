using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoredProcedureInCrpt
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=HP-NETBOOK\SQLEXPRESS01;Initial Catalog=AdventureWorks2016;
                                                    User ID=sa;Password=appforms@123;integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa1 = new SqlDataAdapter("OrderRegionReport", sqlCon);
            SqlDataAdapter sqlDa2 = new SqlDataAdapter("OrderWithDetails", sqlCon);
            sqlDa1.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa2.SelectCommand.CommandType = CommandType.StoredProcedure;
            //sqlDa.SelectCommand.Parameters.AddWithValue("@Price",0);
            DataTable dtb1 = new DataTable();
            sqlDa1.Fill(dtb1);
            DataTable dtb2 = new DataTable();
            sqlDa2.Fill(dtb2);
            sqlCon.Close();
            CrystalReport.crptCountryRegionOrders crpSalesOrder = new CrystalReport.crptCountryRegionOrders();
            crpSalesOrder.Database.Tables["OrderRegionReport"].SetDataSource(dtb1);
            crpSalesOrder.Database.Tables["OrderWithDetails"].SetDataSource(dtb2);
            crvReport.ReportSource = null;
            crvReport.ReportSource = crpSalesOrder;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa1 = new SqlDataAdapter("AnnuallyOrderReport", sqlCon);
            SqlDataAdapter sqlDa2 = new SqlDataAdapter("MonthlySalesOrderData", sqlCon);
            sqlDa1.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa2.SelectCommand.CommandType = CommandType.StoredProcedure;
            //sqlDa.SelectCommand.Parameters.AddWithValue("@Price",0);
            DataTable dtb1 = new DataTable();
            sqlDa1.Fill(dtb1);
            DataTable dtb2 = new DataTable();
            sqlDa2.Fill(dtb2);
            sqlCon.Close();
            CrystalReport.crptMonthlySalesOrder crpSalesOrder = new CrystalReport.crptMonthlySalesOrder();
            crpSalesOrder.Database.Tables["AnnuallyOrderReport"].SetDataSource(dtb1);
            crpSalesOrder.Database.Tables["MonthlySalesOrderData"].SetDataSource(dtb2);
            crvReport.ReportSource = null;
            crvReport.ReportSource = crpSalesOrder;
        }
    }
}
