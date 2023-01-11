using OpenTap;   // Use OpenTAP infrastructure/core components (log,TestStep definition, etc)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyOpenTapShare;


namespace MyPluginVision
{
    [Display("Scope Follow", Group: "MyVisionPlugin", Description: "Insert description here")]
    public class ScopeFollow : TestStep
    {
        #region Settings
        // ToDo: Add property here for each parameter the end user should be able to change.
        [Display("Instrument")]
        public MyInstrument1 Inst { get; set; }

        [Display("OnOff")]
        public bool isOn { get; set; }
        #endregion

        public ScopeFollow()
        {
            // ToDo: Set default values for properties / settings.
        }

        public override void Run()
        {
            // ToDo: Add test case code.
            RunChildSteps(); //If the step supports child steps.

            Log.Info("Scope Follow");
            var resp = Inst.ScpiQuery($"vis:enable_follow_mode {isOn}");

            Log.Info($"Scope Follow set {resp}");

            // If no verdict is used, the verdict will default to NotSet.
            // You can change the verdict using UpgradeVerdict() as shown below.
            // UpgradeVerdict(Verdict.Pass);
        }
    }
}
