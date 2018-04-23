Imports System
Imports System.Text
Imports System.Linq
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports System.Collections.Generic
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.Model.Core
Imports DevExpress.ExpressApp.Model.DomainLogics
Imports DevExpress.ExpressApp.Model.NodeGenerators
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.ReportsV2
Imports FilterReportParameter.Module.Report

Namespace FilterReportParameter.Module
    Public NotInheritable Partial Class FilterReportParameterModule
        Inherits ModuleBase

        Public Sub New()
            InitializeComponent()
            BaseObject.OidInitializationMode = OidInitializationMode.AfterConstruction
        End Sub
        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Dim updater As ModuleUpdater = New DatabaseUpdate.Updater(objectSpace, versionFromDB)
            Dim reportUpdater As New PredefinedReportsUpdater(Application, objectSpace, versionFromDB)
            reportUpdater.AddPredefinedReport(Of DemoReport)("Demo Report")
            Return New ModuleUpdater() { updater, reportUpdater }
        End Function
        Public Overrides Sub CustomizeTypesInfo(ByVal typesInfo As ITypesInfo)
            MyBase.CustomizeTypesInfo(typesInfo)
            CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo)
        End Sub
    End Class
End Namespace
