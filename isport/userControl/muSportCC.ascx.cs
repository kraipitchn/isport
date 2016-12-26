using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.Mobile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.MobileControls;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using MobileLibrary;
using WebLibrary;
namespace isport
{
    public partial class muSportCC : System.Web.UI.MobileControls.MobileUserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void uDataBind()
        {
            try
            {
                string timeRef = DateTime.Now.ToString("HH:mm");
                TimeSpan diff24 = DateTime.Now - new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 00, 00);
                TimeSpan diff18 = DateTime.Now - new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 00, 00);

                decimal addTime = (diff18.Hours < 0 && diff24.Hours >= 0) ? 0 : +1;
                // ��ʴ 
                AppCodeSportCC appCode = new AppCodeSportCC();
                string str = "��ʴ� HOT! (" + appCode.GetCountScore(AppCodeSportCC.MatchType.inprogress, addTime, "N") + ")";
                this.Controls.AddAt(this.Controls.Count,Utilities.Link(str, true, "../sportcc_i1.aspx?p=cc&m=ls", "Left"));

                //��ػ���ѹ���
                str = "��ػ���ѹ��� (" + appCode.GetCountScore(AppCodeSportCC.MatchType.Finished, addTime, "N") + ")";
                this.Controls.AddAt(this.Controls.Count, Utilities.Link(str, true, "../sportcc_i1.aspx?p=cc&m=td", "Left"));

                //��ػ��������ҹ���
                str = "��ػ��������ҹ��� (" + appCode.GetCountScore(AppCodeSportCC.MatchType.Finished, -1, "N") + ")";
                this.Controls.AddAt(this.Controls.Count, Utilities.Link(str, true, "../sportcc_i1.aspx?p=cc&m=lt", "Left"));

                //�š���觢ѹ
                str = "�š���觢ѹ (" + appCode.GetCountScore(AppCodeSportCC.MatchType.Finished, -7, "Y") + ")";
                this.Controls.AddAt(this.Controls.Count, Utilities.Link(str, true, "../sportcc_i1.aspx?p=cc&m=wk", "Left"));
            }
            catch(Exception ex)
            {
                ExceptionManager.WriteError(" sportCC uDataBind>> " + ex.Message);
            }
        }

        
    }
}
