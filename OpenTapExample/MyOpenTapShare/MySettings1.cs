using OpenTap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MyOpenTapShare
{
    [Display("MySettings", Description: "Add a description here")]
    public class MySettings1 : ComponentSettings<MySettings1>
    {
        // TODO: Add settings here as properties, use DisplayAttribute to indicate to the GUI
        //       how the setting should be displayed.
        //       Example:
        //[Display("Category\\Example Setting", Description:" Just an example")]
        //public bool ExampleSetting { get; set; }
        [Display("Example Setting", Description: " Just an example")]
        public bool ExampleSetting { get; set; }
    }
}
