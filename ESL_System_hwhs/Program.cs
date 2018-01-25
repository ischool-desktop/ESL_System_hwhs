using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FISCA;
using FISCA.Presentation;
using JHSchool;
using FISCA.Permission;


namespace ESL_System_hwhs
{
    public class Program
    {
        [FISCA.MainMethod()]
        public static void Main()
        {
            Catalog ribbon = RoleAclSource.Instance["教務作業"]["功能按鈕"];
            ribbon.Add(new RibbonFeature("ESL評分樣版設定", "ESL評分樣版設定"));

            RibbonBarButton rbItem = JHSchool.Affair.EduAdmin.Instance.RibbonBarItems["基本設定"]["設定"];
            
            rbItem["ESL評分樣版設定"].Enable = Framework.User.Acl["ESL評分樣版設定"].Executable;
            rbItem["ESL評分樣版設定"].Click += delegate
            {
                new HsinChu.JHEvaluation.CourseExtendControls.Ribbon.AssessmentSetupManager().ShowDialog();
            };


        }
    }
}
