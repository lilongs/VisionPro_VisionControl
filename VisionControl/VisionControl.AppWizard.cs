using System;

namespace VisionControl
{
    partial class VisionControl
    {
        ///////////////////////// START WIZARD GENERATED
        // cognex.wizard.globals.begin
        private static string mVppFilename = @"E:\项目文件\2019\Vision\QuickBuild1.vpp";
        private static string mApplicationName = "QuickBuild1";
        private static bool mUsePasswords = false;
        private static bool mQuickBuildAccess = true;
        private const string mDefaultAdministratorPassword = "";
        private const string mDefaultSupervisorPassword = "";
        private static DateTime mGenerationDateTime = new DateTime(2019, 7, 16, 8, 19, 7);
        private static string mGeneratedByVersion = "59.0.0.0";
        // cognex.wizard.globals.end
        ///////////////////////// END WIZARD GENERATED
        public void setApplication(string filePath)
        {
            mVppFilename = filePath;
        }

        private void Wizard_FormLoad()
        {
            ///////////////////////// START WIZARD GENERATED
            // cognex.wizard.formloadactions
            ///////////////////////// END WIZARD GENERATED
        }

        private void Wizard_AttachPropertyProviders()
        {
            ///////////////////////// START WIZARD GENERATED
            // cognex.wizard.attachpropertyproviders
            ///////////////////////// END WIZARD GENERATED
        }

        private void Wizard_DetachPropertyProviders()
        {
            ///////////////////////// START WIZARD GENERATED
            // cognex.wizard.detachpropertyproviders
            ///////////////////////// END WIZARD GENERATED
        }

        private void Wizard_EnableControls(bool running)
        {
            ///////////////////////// START WIZARD GENERATED
            // cognex.wizard.enablecontrols
            ///////////////////////// END WIZARD GENERATED
        }

        private void Wizard_AddJobTabs(System.Collections.ArrayList newPagesList)
        {
            ///////////////////////// START WIZARD GENERATED
            // begin cognex.wizard.addjobtabs
            switch (mSelectedJob)
            {
                case 0:
                    newPagesList.Add(tabPage_Job0_CogJob1);
                    break;
            }
            // end cognex.wizard.addjobtabs
            ///////////////////////// END WIZARD GENERATED
        }

        private void Wizard_UpdateJobResults(int idx, Cognex.VisionPro.ICogRecord result)
        {
            ///////////////////////// START WIZARD GENERATED
            // begin cognex.wizard.updatejobresults
            // end cognex.wizard.updatejobresults
            ///////////////////////// END WIZARD GENERATED
        }

    }
}
