// Author: MyName
// Copyright:   Copyright 2022 Keysight Technologies
//              You have a royalty-free right to use, modify, reproduce and distribute
//              the sample application files (and/or any modified version) in any way
//              you find useful, provided that you agree that Keysight Technologies has no
//              warranty, obligations or liability for any sample application files.
using OpenTap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using MyOpenTapShare;

namespace MyPluginChuck
{
    [Display("ChuckMoveContact", Group: "MyChuckPlugin", Description: "Insert a description here")]
    [AllowAnyChild]
    public class ChuckMoveContact : TestStep
    {
        #region Settings
        // ToDo: Add property here for each parameter the end user should be able to change

        [Display("Instrument")]
        public MyInstrument1 Inst { get; set; }
        #endregion

        public ChuckMoveContact()
        {
            // ToDo: Set default values for properties / settings.
        }

        public override void Run()
        {
            // ToDo: Add test case code.
            RunChildSteps(); //If the step supports child steps.

            Log.Info("Go To Contact");
            var resp = Inst.ScpiQuery("move_chuck_contact");

            Log.Info(resp);

            // If no verdict is used, the verdict will default to NotSet.
            // You can change the verdict using UpgradeVerdict() as shown below.
            // UpgradeVerdict(Verdict.Pass);
        }
    }
}
