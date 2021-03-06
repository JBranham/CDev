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

namespace CDevGlobal_Demo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddUserToTable recording.
    /// </summary>
    [TestModule("5129373b-4e02-4ee6-a4f9-aaf0ae3b86eb", ModuleType.Recording, 1)]
    public partial class AddUserToTable : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CDevGlobal_DemoRepository repository.
        /// </summary>
        public static CDevGlobal_DemoRepository repo = CDevGlobal_DemoRepository.Instance;

        static AddUserToTable instance = new AddUserToTable();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddUserToTable()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddUserToTable Instance
        {
            get { return instance; }
        }

#region Variables

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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Fname' at .111;.353.", repo.ApplicationUnderTest.FnameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Fname.Click(".111;.353");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Jason' with focus on 'ApplicationUnderTest.Fname'.", repo.ApplicationUnderTest.FnameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Fname.PressKeys("Jason");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LastName' at .139;.353.", repo.ApplicationUnderTest.LastNameInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.LastName.Click(".139;.353");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Branham' with focus on 'ApplicationUnderTest.LastName'.", repo.ApplicationUnderTest.LastNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.LastName.PressKeys("Branham");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Movie' at .123;.533.", repo.ApplicationUnderTest.MovieInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Movie.Click(".123;.533");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Gender' at .615;.615.", repo.ApplicationUnderTest.GenderInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Gender.Click(".615;.615");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.InputTagAdd' at .52;.696.", repo.ApplicationUnderTest.InputTagAddInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.InputTagAdd.Click(".52;.696");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
