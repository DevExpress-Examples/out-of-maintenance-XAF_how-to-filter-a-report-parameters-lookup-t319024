Imports System
Imports System.Linq
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports System.Collections.Generic
Imports DevExpress.Persistent.BaseImpl

Namespace FilterReportParameter.Module.BusinessObjects
    <DefaultClassOptions> _
    Public Class DemoClass
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Property Name() As String
            Get
                Return GetPropertyValue(Of String)("Name")
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", value)
            End Set
        End Property
        Public Property Parameter() As DemoParameter
            Get
                Return GetPropertyValue(Of DemoParameter)("Parameter")
            End Get
            Set(ByVal value As DemoParameter)
                SetPropertyValue("Parameter", value)
            End Set
        End Property
    End Class
End Namespace
