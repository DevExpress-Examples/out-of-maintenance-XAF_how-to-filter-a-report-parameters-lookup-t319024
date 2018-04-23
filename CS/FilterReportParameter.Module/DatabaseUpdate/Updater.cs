using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using FilterReportParameter.Module.BusinessObjects;

namespace FilterReportParameter.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppUpdatingModuleUpdatertopic.aspx
    public class Updater : ModuleUpdater
    {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion)
        {
        }
        public override void UpdateDatabaseAfterUpdateSchema()
        {
            base.UpdateDatabaseAfterUpdateSchema();
            string name = "Test1";
            DemoClass theObject = ObjectSpace.FindObject<DemoClass>(CriteriaOperator.Parse("Name=?", name));
            if (theObject == null)
            {
                theObject = ObjectSpace.CreateObject<DemoClass>();
                theObject.Name = name;
                CreateParameters();
                theObject.Parameter = ObjectSpace.FindObject<DemoParameter>(CriteriaOperator.Parse("Name=?", "Param 102"));
            }
            name = "Test2";
            theObject = ObjectSpace.FindObject<DemoClass>(CriteriaOperator.Parse("Name=?", name));
            if (theObject == null)
            {
                theObject = ObjectSpace.CreateObject<DemoClass>();
                theObject.Name = name;
                theObject.Parameter = ObjectSpace.FindObject<DemoParameter>(CriteriaOperator.Parse("Name=?", "Param 202"));
            }
        }
        private void CreateParameters()
        {
            for (int i = 0; i < 1000; i++)
            {
                DemoParameter obj = ObjectSpace.CreateObject<DemoParameter>();
                obj.Name = "Param " + i;
                obj.Category = "Category " + i % 10;
                //if (i / 1000 == 0)
                //{
                //    ObjectSpace.CommitChanges();
                //}
            }
        }
    }
}
