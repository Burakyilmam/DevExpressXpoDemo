﻿using DevExpress.Xpo;
using DevExpressXpoDemo.Xdb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressXpoDemo
{
    public partial class adminList : Form
    {
        public adminList()
        {
            InitializeComponent();
        }
        private void userList_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        public void GetAll()
        {
            var adminlist = Sabitler.uow.Query<Admin>().ToList();
            gridUser.DataSource = adminlist;
        }
    }
}
