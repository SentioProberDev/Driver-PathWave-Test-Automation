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
    [Display("ChuckMoveXY", Group: "MyChuckPlugin", Description: "Insert a description here")]
    public class ChuckMoveXY : TestStep
    {
        #region Settings
        // ToDo: Add property here for each parameter the end user should be able to change
        [Display("Instrument")]
        public MyInstrument1 Inst { get; set; }

        [Display("X", Group: "Movement", Order: 0)]
        public double X { get; set; }

        [Display("Y", Group: "Movement", Order: 1)]
        public double Y { get; set; }

        #endregion

        public ChuckMoveXY()
        {
            // ToDo: Set default values for properties / settings.
        }

        public override void Run()
        {
            // ToDo: Add test case code.
            RunChildSteps(); //If the step supports child steps.

            Log.Info("Go To XY");
            var resp = Inst.ScpiQuery($"move_chuck_xy Zero,{X},{Y}");
            Log.Info(resp);
            
            // If no verdict is used, the verdict will default to NotSet.
            // You can change the verdict using UpgradeVerdict() as shown below.
            // UpgradeVerdict(Verdict.Pass);
        }
    }
}
