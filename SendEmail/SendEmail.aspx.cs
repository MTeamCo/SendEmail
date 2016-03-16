using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SendEmail
{
    public partial class SendEmail : System.Web.UI.Page
    {
        const int ColumnSelect = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            generateFirstTable();
            generateSecondTable();
            divMessage.Visible = false;
        }

        protected void gridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType != DataControlRowType.Header)
            {
                e.Row.Cells[ColumnSelect].Controls.Add(new CheckBox());
            }
        }

        void generateFirstTable()
        {
            DataTable dt = new DataTable();
            DataColumn column = new DataColumn();
            dt.Columns.Add("انتخاب");
            dt.Columns.Add("ردیف");
            dt.Columns.Add("نام مسیر");
            dt.Columns.Add("مسیرتورهای نیم روزه تهرانگردی ستاد گردشگری نوروز 95 شهرداری تهران");

            DataRow row0 = dt.NewRow();
            row0[1] = "1";
            row0[2] = "طهران قدیم   ";
            row0[3] = "امامزاده یحیی – سرای کاظمی – حمام نواب – بو ستان هرندی";
            dt.Rows.Add(row0);
            //////////////////////////////////////////////////
            DataRow row = dt.NewRow();
            row[1] = "2";
            row[2] = "پرندگان  ";
            row[3] = "باغ موزه قصر – خانه هروی- باغ پرندگان";
            dt.Rows.Add(row);
            //////////////////////////////////////////////////
            DataRow row1 = dt.NewRow();
            row1[1] = "3";
            row1[2] = "گذر سی تیر ";
            row1[3] = "موزه ایران باستان – موزه علوم وفن آ وری -  موزه آبگینه";
            dt.Rows.Add(row1);
            /////////////////////////////////////////////////
            DataRow row2 = dt.NewRow();
            row2[1] = "4";
            row2[2] = "نیاوران  ";
            row2[3] = "امامزاده قاسم – کاخ  موزه نیاوران – موزه حیات وحش دارآباد";
            dt.Rows.Add(row2);
            //////////////////////////////////////////////////
            DataRow row3 = dt.NewRow();
            row3[1] = "5";
            row3[2] = "آزادی ";
            row3[3] = "	برج آزادی – دریاچه شهدای خلیج فارس";
            dt.Rows.Add(row3);
            /////////////////////////////////////////////////
            DataRow row4 = dt.NewRow();
            row4[1] = "6";
            row4[2] = "گلستان  ";
            row4[3] = "کاخ گلستان – موزه مقدم – باغ موزه نگارستان ";
            dt.Rows.Add(row4);
            //////////////////////////////////////////////////
            DataRow row5 = dt.NewRow();
            row5[1] = "7";
            row5[2] = "شهرک سینمایی ";
            row5[3] = "شهرک سینمایی- باغ گیاه شناسی";
            dt.Rows.Add(row5);
            /////////////////////////////////////////////////
            DataRow row6 = dt.NewRow();
            row6[1] = "8";
            row6[2] = "سعد آباد  ";
            row6[3] = "باغ فردوس – موزه سینما – کاخ موزه سعد اباد";
            dt.Rows.Add(row6);
            //////////////////////////////////////////////////
            DataRow row7 = dt.NewRow();
            row7[1] = "9";
            row7[2] = "برج میلاد ";
            row7[3] = "برج میلاد  - پارک ژوراسیک - پل طبیعت";
            dt.Rows.Add(row7);
            /////////////////////////////////////////////////
            DataRow row8 = dt.NewRow();
            row8[1] = "10";
            row8[2] = "سورتمه  ";
            row8[3] = "امامزاده علی اکبر چیذر – خانه موزه استاد انتظامی – سورتمه تهران";
            dt.Rows.Add(row8);
            /////////////////////////////////////////////////

            gridView1.DataSource = dt;
            gridView1.DataBind();
        }

        void generateSecondTable()
        {
            DataTable dt = new DataTable();
            DataColumn column = new DataColumn();
            dt.Columns.Add("انتخاب");
            dt.Columns.Add("ردیف");
            dt.Columns.Add("نام تور");
            dt.Columns.Add("مسیرتورهای یک روزه تهرانگردی ستاد گردشگری نوروز 95 شهرداری تهران");

            DataRow row0 = dt.NewRow();
            row0[1] = "1";
            row0[2] = "حرم";
            row0[3] = "جماران – امامزاده قاسم - حرم مطهر(ره ) – حرم شاه عبدالعظیم";
            dt.Rows.Add(row0);
            //////////////////////////////////////////////////
            DataRow row = dt.NewRow();
            row[1] = "2";
            row[2] = "ری باستان";
            row[3] = "چشمه علی – ابن بابویه – برج طغرل – تپه میل حضرت عبدالعظیم حسنی - بی بی شهربانو";
            dt.Rows.Add(row);
            //////////////////////////////////////////////////
            DataRow row1 = dt.NewRow();
            row1[1] = "3";
            row1[2] = "بهارستان ";
            row1[3] = "میدان بهارستان – باغ موزه نگارستان (مکتب کمال الملک ) – موزه مقدم – میدان مشق";
            dt.Rows.Add(row1);
            /////////////////////////////////////////////////
            DataRow row2 = dt.NewRow();
            row2[1] = "4";
            row2[2] = "شمیرانات  ";
            row2[3] = "قلمستان – باغ فردوس –موزه موسیقی –موزه سینما –امامزاده صالح – باغ موزه ایرانی";
            dt.Rows.Add(row2);
            //////////////////////////////////////////////////
            DataRow row3 = dt.NewRow();
            row3[1] = "5";
            row3[2] = "اراضی عباس اباد ";
            row3[3] = "	آب و آتش – بوستان بنادر- پل طبیعت – برج پرچم – گنبد مینا (پلانتاریوم)- بوستان نوروز – موزه دفاع مقدس";
            dt.Rows.Add(row3);
            /////////////////////////////////////////////////
            DataRow row4 = dt.NewRow();
            row4[1] = "6";
            row4[2] = "سه برج  ";
            row4[3] = "برج طغرل – برج آزادی – برج میلاد ";
            dt.Rows.Add(row4);
            //////////////////////////////////////////////////
            DataRow row5 = dt.NewRow();
            row5[1] = "7";
            row5[2] = "شهرک سینمایی ";
            row5[3] = "شهرک سینمایی- باغ گیاه شناسی";
            dt.Rows.Add(row5);
            /////////////////////////////////////////////////
            DataRow row6 = dt.NewRow();
            row6[1] = "8";
            row6[2] = "سعد آباد  ";
            row6[3] = "باغ فردوس – موزه سینما – کاخ موزه سعد اباد";
            dt.Rows.Add(row6);
            //////////////////////////////////////////////////
            DataRow row7 = dt.NewRow();
            row7[1] = "9";
            row7[2] = "برج میلاد ";
            row7[3] = "برج میلاد  - پارک ژوراسیک - پل طبیعت";
            dt.Rows.Add(row7);
            /////////////////////////////////////////////////
            DataRow row8 = dt.NewRow();
            row8[1] = "10";
            row8[2] = "سورتمه  ";
            row8[3] = "امامزاده علی اکبر چیذر – خانه موزه استاد انتظامی – سورتمه تهران";
            dt.Rows.Add(row8);
            /////////////////////////////////////////////////

            gridView2.DataSource = dt;
            gridView2.DataBind();
        }

        protected void gridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType != DataControlRowType.Header)
            {
                e.Row.Cells[ColumnSelect].Controls.Add(new CheckBox());
            }
        }

        protected void btnSend_OnClick(object sender, EventArgs e)
        {
            int firstCount = 0;
            int secondCount = 0;
            StringBuilder firstTableRows=new StringBuilder();
            StringBuilder secondTableRows = new StringBuilder();
            firstTableRows.Append("<tr><th>" + "ردیف" + "</th>" + "<th>" + "نام مسیر" + "</th>" + "<th>" + "مسیرتورهای نیم روزه تهرانگردی ستاد گردشگری نوروز 95 شهرداری تهران" + "</th></tr>");
            secondTableRows.Append("<tr><th>" + "ردیف" + "</th>" + "<th>" + "نام تور" + "</th>" + "<th>" + "مسیرتورهای یک روزه تهرانگردی ستاد گردشگری نوروز 95 شهرداری تهران" + "</th></tr>");
            foreach (GridViewRow row in gridView1.Rows)
            {
                //Could also use (CheckBox)row.Cells[ColumnSelect].FindControl if you give the checkboxes IDs when generating them.
                CheckBox cb = (CheckBox)row.Cells[ColumnSelect].Controls[0];

                if (cb.Checked)
                {
                    firstCount += 1;
                    firstTableRows.Append("<tr><td style='padding: 4px; border:1px solid black'>"+row.Cells[1].Text+"</td>"+"<td style='padding: 4px; border:1px solid black'>"+row.Cells[2].Text+"</td>"+"<td style='padding: 4px; border:1px solid black'>"+row.Cells[3].Text+"</td></tr>");

                }
            }
            foreach (GridViewRow row in gridView2.Rows)
            {
                //Could also use (CheckBox)row.Cells[ColumnSelect].FindControl if you give the checkboxes IDs when generating them.
                CheckBox cb = (CheckBox)row.Cells[ColumnSelect].Controls[0];

                if (cb.Checked)
                {
                    secondCount += 1;
                    secondTableRows.Append("<tr><td style='padding: 4px; border:1px solid black'>" + row.Cells[1].Text + "</td>" + "<td style='padding: 4px; border:1px solid black'>" + row.Cells[2].Text + "</td>" + "<td style='padding: 4px; border:1px solid black'>" + row.Cells[3].Text + "</td></tr>");

                }
            }
            if (txtMobile.Text == "" || (firstCount == 0 && secondCount == 0))
            {
                divMessage.Visible = true;
            }
            else
            {
                SendMail(txtEmail.Text, firstTableRows.ToString(), secondTableRows.ToString());    
                Response.Redirect("WebForm1.aspx");
            }
        }


        protected void SendMail(string email, string firstTableRows, string SecondTableRows)
        {

            var fromAddress = "Gmail@gmail.com";
            var toAddress = email;
            //Password of your gmail address
            const string fromPassword = "Password";
            // Passing the values and make a email formate to display

            string emailTemplate = System.IO.File.ReadAllText(Server.MapPath("/EmailTemplate/RecoverPassword.html"));
            emailTemplate = emailTemplate.Replace("$FirstTableRows$", firstTableRows);
            emailTemplate = emailTemplate.Replace("$SecondTableRows$", SecondTableRows);

            emailTemplate = emailTemplate.Replace("$uFullName$", txtFullName.Text);
            emailTemplate = emailTemplate.Replace("$uEmail$", txtEmail.Text);
            emailTemplate = emailTemplate.Replace("$uMobile$", txtMobile.Text);
            emailTemplate = emailTemplate.Replace("$uNationalCode$", txtNationalCode.Text);
            emailTemplate = emailTemplate.Replace("$uProvince$", txtProvince.Text);
            emailTemplate = emailTemplate.Replace("$uCity$", txtCity.Text);
            emailTemplate = emailTemplate.Replace("$uRegion$", txtRegion.Text);
            emailTemplate = emailTemplate.Replace("$uDistrict$", txtDistrict.Text);
            WebMail.SendMail(emailTemplate, WebConfigurationManager.AppSettings["RecoverPasswordSubject"], WebConfigurationManager.AppSettings["SmtpServer"], WebConfigurationManager.AppSettings["EmailUsername"], WebConfigurationManager.AppSettings["EmailPassword"], WebConfigurationManager.AppSettings["AdminEmail"]);
        }
    }
}