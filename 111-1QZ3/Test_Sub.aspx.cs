using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ3
{
    public partial class Test_Sub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Get("txt_Phone") != null)
            {
                lb_Msg.Text = "保單號碼：" + Request.Form.Get("tb_Num") + "<br />" + "通訊種類：" + Request.Form.Get("rbl_Phone") + "<br />" +
               "通訊號碼：" + Request.Form.Get("txt_Phone") + "<br />" + "所在城市：" + Request.Form.Get("dpl_City") + "<br />" +
               "所在區域：" + Request.Form.Get("dpl_Area");
            }
            else
            {
                lb_Msg.Text = "保單號碼：" + Request.Form.Get("tb_Num") + "<br />" + "通訊種類：" + Request.Form.Get("rbl_Phone") + "<br />" +
                "所在城市：" + Request.Form.Get("dpl_City") + "<br />" +
                "所在區域：" + Request.Form.Get("dpl_Area");
            }
        }
    }
}