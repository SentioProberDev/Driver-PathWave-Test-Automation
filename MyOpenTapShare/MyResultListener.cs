using OpenTap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace MyOpenTapShare
{
    [Display("MyResultListener", Group: "MyOpenTapShare", Description: "Insert a description here")]
    public class MyResultListener : ResultListener
    {
        #region Settings
        // ToDo: Add property here for each parameter the end user should be able to change
        [Display("Instrument")]
        public MyInstrument1 Inst { get; set; }
        #endregion

        public MyResultListener()
        {
            Name = "MyRes";
            // ToDo: Set default values for properties / settings.
        }

        public override void OnTestPlanRunStart(TestPlanRun planRun)
        {
            //Add handling code for test plan run start.
        }

        public override void OnTestStepRunStart(TestStepRun stepRun)
        {
            //Add handling code for test step run start.
        }

        public override void OnResultPublished(Guid stepRun, ResultTable result)
        {
            // Add handling code for result data.
            OnActivity();
        }

        public override void OnTestStepRunCompleted(TestStepRun stepRun)
        {
            // var resp = Inst.ScpiQuery("get_chuck_xy");
            // Log.Info($"Test Done...{resp}");
            //Add handling code for test step run completed.
        }

        public override void OnTestPlanRunCompleted(TestPlanRun planRun, Stream logStream)
        {
            //Add handling for test plan run completed.
        }

        public override void Open()
        {
            base.Open();
            //Add resource open code.
        }

        public override void Close()
        {
            //Add resource close code.
            base.Close();
        }
    }
}
