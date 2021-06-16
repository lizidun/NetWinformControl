// ***********************************************************************
// Assembly         : HZH_Controls
// Created          : 08-08-2019
//
// ***********************************************************************
// <copyright file="FrmWithOKCancel1.cs">
//     Copyright by Huang Zhenghui(黄正辉) All, QQ group:568015492 QQ:623128629 Email:623128629@qq.com
// </copyright>
//
// Blog: https://www.cnblogs.com/bfyx
// GitHub：https://github.com/kwwwvagaa/NetWinformControl
// gitee：https://gitee.com/kwwwvagaa/net_winform_custom_control.git
//
// If you use this code, please keep this note.
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HZH_Controls.Forms
{
    /// <summary>
    /// Class FrmWithOKCancel1.
    /// Implements the <see cref="HZH_Controls.Forms.FrmWithTitle" />
    /// </summary>
    /// <seealso cref="HZH_Controls.Forms.FrmWithTitle" />
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner))]
    public partial class FrmWithOKCancel1 : FrmWithTitle
    {

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        [Description("消息内容"), Category("自定义")]
        public string Msg
        {
            get
            {
                return label_msg.Text;
            }
            set
            {
                label_msg.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        /// <value>The picture.</value>
        [Description("消息图片"), Category("自定义")]
        public Image Pic
        {
            get
            {
                return pictureBox_msg.BackgroundImage;
            }
            set
            {
                pictureBox_msg.BackgroundImage = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmWithOKCancel1" /> class.
        /// </summary>
        public FrmWithOKCancel1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the BtnClick event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnOK_BtnClick(object sender, EventArgs e)
        {
            DoEnter();
        }

        /// <summary>
        /// Handles the BtnClick event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnCancel_BtnClick(object sender, EventArgs e)
        {
            DoEsc();
        }

        /// <summary>
        /// Does the enter.
        /// </summary>
        protected override void DoEnter()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Handles the VisibleChanged event of the FrmWithOKCancel1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmWithOKCancel1_VisibleChanged(object sender, EventArgs e)
        {
        }
    }
}
