using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ3
{
    public partial class Test : System.Web.UI.Page
    {
        string[] s_City = new string[3] { "台北市", "新北市", "台中市" };
        string[,] s_Area = new string[3, 3] {
            {"中正區", "文山區", "大安區"},
            {"淡水區", "石碇區", "土城區"},
            {"西屯區", "北屯區", "東區"}
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i_ct = 0; i_ct < s_City.Length; i_ct++)
                {
                    ListItem L_i = new ListItem();
                    L_i.Text = s_City[i_ct];
                    L_i.Value = s_City[i_ct];

                    dpl_City.Items.Add(L_i);
                }
                mt_GenSecondList();
            }
        }

        protected void mt_GenSecondList()
        {
            int i_ind = dpl_City.SelectedIndex;
            dpl_Area.Items.Clear();
            for (int i_ct = 0; i_ct < s_Area.GetLength(1); i_ct++)
            {
                ListItem L_i = new ListItem();
                L_i.Text = s_Area[i_ind, i_ct];
                L_i.Value = s_Area[i_ind, i_ct];

                dpl_Area.Items.Add(L_i);
            }
        }
        protected void rbl_Phone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbl_Phone.SelectedIndex == 2)
            {
                txt_Phone.Visible = false;
            }
            else
            {
                txt_Phone.Visible = true;
            }
        }

        protected void dpl_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            mt_GenSecondList();
        }


    }
}