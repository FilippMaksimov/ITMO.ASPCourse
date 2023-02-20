using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data;
using EntityWeb;

public partial class Reg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            //Проверка по валидации
            Page.Validate();
            if (!Page.IsValid)
            {
                return;
            }

            GuestResponse rspv = new GuestResponse(name.Text, email.Text, phone.Text, checkBoxYN.Checked);
            ResponseRepository.GetRepository().AddResponse(rspv);
            if (checkBoxYN.Checked)
            {
                Report report1 = new Report(TextBoxTitle.Text, TextBoxTextAnnot.Text);
                rspv.Reports.Add(report1);
            }
            if (TextBoxTitle2.Text != "" || TextBoxTextAnnot2.Text != "")
            {
                Report report2 = new Report(TextBoxTitle2.Text, TextBoxTextAnnot2.Text);
                rspv.Reports.Add(report2);
            }
            try
            {
                SampleContext context = new SampleContext();
                context.GuestResponses.Add(rspv);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Response.Redirect("Ошибка" + ex.Message);
            }
            if (rspv.WillAttend.HasValue && rspv.WillAttend.Value)
            {
                Response.Redirect("seeyouthere.html");
            }
            else
            {
                Response.Redirect("sorryyoucantcome.html");
            }
        }
    }
}