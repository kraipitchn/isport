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

namespace isport.userControl
{
    public partial class uFootballTable : System.Web.UI.MobileControls.MobileUserControl
    {

        #region TextHeader
        public string GetHeaderThaiPoint()
        {
            return "���ҧ��ṹ";
        }
        public string GetTextNo()
        {
            return "�ѹ�Ѻ";
        }
        public string GetTextCuntry()
        {
            return "�����";
        }

        public string GetTextMatch()
        {
            return "��";
        }

        public string GetTextScore()
        {
            return "��ṹ";
        }
        public string GetTextLoss()
        {
            return "������";
        }
        

        private string strPlace;
        private string strTeamName;
        private string strTotalPlay;
        private string strTotalPoint;
        private string strTotalDiff;

        public string PLACE
        {
            get
            {
                return strPlace;
            }
            set
            {
                strPlace = value;
            }
        }
        public string TEAM_NAME
        {
            get
            {
                return strTeamName;
            }
            set
            {
                strTeamName = value;
            }
        }
        public string TOTAL_PLAY
        {
            get
            {
                return strTotalPlay;
            }
            set
            {
                strTotalPlay = value;
            }
        }

        public string TOTAL_POINT
        {
            get
            {
                return strTotalPoint;
            }
            set
            {
                strTotalPoint = value;
            }
        }

        public string TOTAL_DIFF
        {
            get
            {
                return strTotalDiff;
            }
            set
            {
                strTotalDiff = value;
            }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void udataBinding(DataTable dt)
        {

            objTable.DataSource = dt;
            objTable.DataBind();
        }
    }
}
