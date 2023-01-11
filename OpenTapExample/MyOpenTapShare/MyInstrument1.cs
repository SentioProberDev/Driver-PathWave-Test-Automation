using OpenTap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

//Note this template assumes that you have a SCPI based instrument, and accordingly
//extends the ScpiInstrument base class.

//If you do NOT have a SCPI based instrument, you should modify this instance to extend
//the (less powerful) Instrument base class.

namespace MyOpenTapShare
{
    [Display("MyInstrument1", Group: "MyOpenTapShare", Description: "Insert a description here")]
    public class MyInstrument1 : ScpiInstrument
    {
        #region Settings
        // ToDo: Add property here for each parameter the end user should be able to change
        

        [Display("Some property")]
        public string SomeProperty { get; set; }


        #endregion

        public MyInstrument1()
        {
            Name = "MyINST";
            // ToDo: Set default values for properties / settings.
            //Open();
        }

        /// <summary>
        /// Open procedure for the instrument.
        /// </summary>
        public override void Open()
        {

            base.Open();
            // TODO:  Open the connection to the instrument here

            //if (!IdnString.Contains("Instrument ID"))
            //{
            //    Log.Error("This instrument driver does not support the connected instrument.");
            //    throw new ArgumentException("Wrong instrument type.");
            // }

        }

        /// <summary>
        /// Close procedure for the instrument.
        /// </summary>
        public override void Close()
        {
            // TODO:  Shut down the connection to the instrument here.
            base.Close();
        }
    }
}
