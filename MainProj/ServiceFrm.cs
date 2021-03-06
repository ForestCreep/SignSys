﻿using communication_component;
using MainProj.AccountManage;
using MainProj.ConfigConnectionString;
using MainProj.PictureManage;
using MainProj.ShowLeaveMessage;
using MainProj.SignInfoManage;
using SeverToDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProj
{
    public partial class SeviceFrm : Form
    {
        public SeviceFrm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Thread th = new Thread(() =>
             {
                 while (true)
                 {
                     if (DBConnectConfigFrm.isConnect)
                     {
                         b = true;
                     }
                     else
                     {
                         b = false;
                     }
                 }
             });
            th.IsBackground = true;
            th.Start();
        }

        private bool SecurityCheck()
        {
            AuthenticFrm authenticFrm = new AuthenticFrm();
            authenticFrm.StartPosition = FormStartPosition.CenterParent;
            authenticFrm.ShowDialog();
            return authenticFrm.isManager;
        }

        private void tSMICreateAccount_Click(object sender, EventArgs e)
        {
            if (!CheckConnect())
            {
                MessageBox.Show("请先配置数据库连接！");
                return;
            }
            if (SecurityCheck())
            {
                CreateAccountFrm createAccount = new CreateAccountFrm();
                createAccount.StartPosition = FormStartPosition.CenterParent;
                createAccount.ShowDialog();
            }
        }

        private void tSMIDeleteAccount_Click(object sender, EventArgs e)
        {
            if (!CheckConnect())
            {
                MessageBox.Show("请先配置数据库连接！");
                return;
            }
            if (SecurityCheck())
            {
                DeleteAccountFrm deleteAccount = new DeleteAccountFrm();
                deleteAccount.StartPosition = FormStartPosition.CenterParent;
                deleteAccount.ShowDialog();
            }
        }

        private bool CheckConnect()
        {
            if (b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool b = false;

        private void tSMIDBConfig_Click(object sender, EventArgs e)
        {
            DBConnectConfigFrm dBConnectConfigFrm = new DBConnectConfigFrm();
            dBConnectConfigFrm.StartPosition = FormStartPosition.CenterParent;
            dBConnectConfigFrm.ShowDialog();
        }

        private void tSMIViewTimeTable_Click(object sender, EventArgs e)
        {
            if (!CheckConnect())
            {
                MessageBox.Show("请先配置数据库连接！");
                return;
            }
            if (SecurityCheck())
            {
                RefreshTxtMsg("正在查询用户课表...");
                ShowPictureFrm showPictureFrm = new ShowPictureFrm();
                showPictureFrm.StartPosition = FormStartPosition.CenterParent;
                showPictureFrm.ShowDialog();
            }
        }

        private void tSMIViewAllSignInfo_Click(object sender, EventArgs e)
        {
            if (!CheckConnect())
            {
                MessageBox.Show("请先配置数据库连接！");
                return;
            }
            if (SecurityCheck())
            {
                RefreshTxtMsg("正在查询全部用户签到信息...");
                AllSignInfoFrm allSignInfoFrm = new AllSignInfoFrm();
                allSignInfoFrm.StartPosition = FormStartPosition.CenterParent;
                allSignInfoFrm.ShowDialog();
            }
        }

        private void tSMIViewUser_Click(object sender, EventArgs e)
        {
            if (!CheckConnect())
            {
                MessageBox.Show("请先配置数据库连接！");
                return;
            }
            if (SecurityCheck())
            {
                RefreshTxtMsg("正在查询全部用户信息...");
                ShowAllUsersFrm showAllUsersFrm = new ShowAllUsersFrm();
                showAllUsersFrm.StartPosition = FormStartPosition.CenterParent;
                showAllUsersFrm.ShowDialog();
            }
        }

        private void RefreshTxtMsg(string msg)
        {
            this.BeginInvoke(new Action(() => { txtShowMsg.Text += msg + DateTime.Now.ToString() + "\r\n"; }));
        }

        private void tSMIStartListen_Click(object sender, EventArgs e)
        {
            try
            {
                Thread th = new Thread(() =>
                 {
                     if (ServerOperation.SetConnectionToClient())
                     {
                         RefreshTxtMsg("成功开启服务!");
                     }
                     else
                     {
                         RefreshTxtMsg("开启服务失败!");
                     }
                 });
                th.IsBackground = true;
                th.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SeviceFrm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(602, 377);
            //ShowUsersInfo();
            //EntityHelper.GetEntities().Database.Connection.Open();
        }

        private void tSMITodaySignInfo_Click(object sender, EventArgs e)
        {
            if (!CheckConnect())
            {
                MessageBox.Show("请先配置数据库连接！");
                return;
            }
            if (SecurityCheck())
            {
                SignInfoToday signInfoToday = new SignInfoToday();
                signInfoToday.StartPosition = FormStartPosition.CenterParent;
                signInfoToday.ShowDialog();
            }
        }

        private void tSMIViewMessage_Click(object sender, EventArgs e)
        {
            if (!CheckConnect())
            {
                MessageBox.Show("请先配置数据库连接！");
                return;
            }
            if (SecurityCheck())
            {
                ShowLeaveMsgFrm showLeaveMsgFrm = new ShowLeaveMsgFrm();
                showLeaveMsgFrm.StartPosition = FormStartPosition.CenterParent;
                showLeaveMsgFrm.ShowDialog();
            }
        }

        private void tSMITools_Click(object sender, EventArgs e)
        {

        }
    }
}
