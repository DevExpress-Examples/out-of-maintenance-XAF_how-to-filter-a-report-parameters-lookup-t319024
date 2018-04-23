using System;
using System.Linq;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.Persistent.BaseImpl;

namespace FilterReportParameter.Module.BusinessObjects {
    [DefaultClassOptions]
    public class DemoClass : BaseObject {
        public DemoClass(Session session)
            : base(session) {
        }
        public string Name {
            get { return GetPropertyValue<string>("Name"); }
            set { SetPropertyValue("Name", value); }
        }
        public DemoParameter Parameter {
            get { return GetPropertyValue<DemoParameter>("Parameter"); }
            set { SetPropertyValue("Parameter", value); }
        }
    }
}
