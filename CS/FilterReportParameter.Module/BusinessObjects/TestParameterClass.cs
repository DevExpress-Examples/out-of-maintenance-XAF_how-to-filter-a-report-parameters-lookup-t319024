using System;
using System.Linq;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.Persistent.BaseImpl;

namespace FilterReportParameter.Module.BusinessObjects {
    [DefaultClassOptions]
    [DefaultProperty("Name")]
    public class DemoParameter : BaseObject {
        public DemoParameter(Session session)
            : base(session) {
        }
        public string Name {
            get { return GetPropertyValue<string>("Name"); }
            set { SetPropertyValue("Name", value); }
        }
        public string Category {
            get { return GetPropertyValue<string>("Category"); }
            set { SetPropertyValue("Category", value); }
        }
    }
}
