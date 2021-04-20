using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _109_2Mid {
    public partial class Sample2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }       

        protected void ddl_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_Place.Items.Clear();
            if (ddl_Area.SelectedValue == "北區")
            {
                ddl_Place.Items.Add("基隆");
                ddl_Place.Items.Add("台北");
                ddl_Place.Items.Add("新北");
            }
            else if (ddl_Area.SelectedValue == "中區") {
                ddl_Place.Items.Add("苗栗");
                ddl_Place.Items.Add("台中");
                ddl_Place.Items.Add("南投");
            }
        }
        protected void rbl_Res_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbl_Res.SelectedValue == "是")
            {
                tb_Des.Visible = true;
            }
            else
            {
                tb_Des.Visible = false;
                tb_Des.Text = "";
            }
        }
        protected void btn_Sub_Click(object sender, EventArgs e)
        {
            lb_Msg.Text = ddl_Area.SelectedValue + "</br>" + ddl_Place.SelectedValue + "</br>" + tb_Name.Text + "</br>" + tb_Des.Text;
        }

       
    }
}