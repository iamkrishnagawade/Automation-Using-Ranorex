﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace DesktopApp.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CloseApp recording.
    /// </summary>
    [TestModule("bb8b3ec1-ac49-4f9e-a2a8-bf4b12d351e5", ModuleType.Recording, 1)]
    public partial class CloseApp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DesktopApp.DesktopAppRepository repository.
        /// </summary>
        public static global::DesktopApp.DesktopAppRepository repo = global::DesktopApp.DesktopAppRepository.Instance;

        static CloseApp instance = new CloseApp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseApp()
        {
            varAppPid = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseApp Instance
        {
            get { return instance; }
        }

#region Variables

        string _varAppPid;

        /// <summary>
        /// Gets or sets the value of variable varAppPid.
        /// </summary>
        [TestVariable("a2156a75-ff6f-4f10-b066-c4d1b3f6c9a3")]
        public string varAppPid
        {
            get { return _varAppPid; }
            set { _varAppPid = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Closing application with Process ID bound to variable $varAppPid.", new RecordItemIndex(0));
            Host.Current.CloseApplication(int.Parse(varAppPid), new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
