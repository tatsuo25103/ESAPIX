﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Interfaces;

namespace ESAPIX15._1Template.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private IScriptContext _ctx;

        public MainViewModel(IScriptContext ctx)
        {
            _ctx = ctx;

            //Example data bind
            Username = ctx.CurrentUser.Id;
        }


        private string username;

        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

    }
}
