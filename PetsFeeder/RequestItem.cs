﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter;
using Presenter.IViews;

namespace PetsFeeder
{
    public partial class RequestItem : UserControl, IRequestItemView
    {
        RequestItemPresenter presenter;
        int requestID;
        public RequestItem(int requestID)
        {
            InitializeComponent();
            this.requestID = requestID;
            presenter = new RequestItemPresenter(this);
            presenter.GetUserRequest(requestID);
        }
        public void UpdateInformation(string username)
		{
            usernameLabel.Text = username;
		}

    }
}
