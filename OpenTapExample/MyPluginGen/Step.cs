using OpenTap;   // Use OpenTAP infrastructure/core components (log,TestStep definition, etc)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPluginGen
{
    [Display("CheckInRange", Group: "Test", Description: "Insert description here")]
    public class Step : TestStep
    {
        #region Settings
        // ToDo: Add property here for each parameter the end user should be able to change.
        [Display("Max Numbers", Group: "Settings", Order: 0)]
        public int MaxLimit { get; set; }

        [Display("Min Numbers", Group: "Settings", Order: 1)]
        public int MinLimit { get; set; }
        #endregion

        public Step()
        {
            // ToDo: Set default values for properties / settings.
            Rules.Add(() => MaxLimit >= MinLimit, "MaxLimit must >= MinLimit", "MaxLimit", "MinLimit");
            MaxLimit = 15;
            MinLimit = 5;
        }

        public override void Run()
        {
            // ToDo: Add test case code.
            RunChildSteps(); //If the step supports child steps.

            if (10 < MinLimit || 10 > MaxLimit)
            {
                UpgradeVerdict(Verdict.Fail);
            }
            else
            {
                UpgradeVerdict(Verdict.Pass);
            }

            // If no verdict is used, the verdict will default to NotSet.
            // You can change the verdict using UpgradeVerdict() as shown below.
            // UpgradeVerdict(Verdict.Pass);
        }
    }
}
