﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style", ConfigurationName:="ServiceReference1.ZWS_MATERIALS")>  _
    Public Interface ZWS_MATERIALS
        
        'CODEGEN: Generating message contract since the operation ZfmSpuMaterials is neither RPC nor document wrapped.
        <System.ServiceModel.OperationContractAttribute(Action:="urn:sap-com:document:sap:soap:functions:mc-style:ZWS_MATERIALS:ZfmSpuMaterialsReq"& _ 
            "uest", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ZfmSpuMaterials(ByVal request As ServiceReference1.ZfmSpuMaterialsRequest) As ServiceReference1.ZfmSpuMaterialsResponse1
        
        <System.ServiceModel.OperationContractAttribute(Action:="urn:sap-com:document:sap:soap:functions:mc-style:ZWS_MATERIALS:ZfmSpuMaterialsReq"& _ 
            "uest", ReplyAction:="*")>  _
        Function ZfmSpuMaterialsAsync(ByVal request As ServiceReference1.ZfmSpuMaterialsRequest) As System.Threading.Tasks.Task(Of ServiceReference1.ZfmSpuMaterialsResponse1)
    End Interface
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style")>  _
    Partial Public Class ZfmSpuMaterials
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style")>  _
    Partial Public Class ZspuMaterial
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private matnrField As String
        
        Private matCatField As String
        
        Private mtartField As String
        
        Private maktgField As String
        
        Private meinsField As String
        
        Private matklField As String
        
        Private steucField As String
        
        Private taxTypeField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property Matnr() As String
            Get
                Return Me.matnrField
            End Get
            Set
                Me.matnrField = value
                Me.RaisePropertyChanged("Matnr")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property MatCat() As String
            Get
                Return Me.matCatField
            End Get
            Set
                Me.matCatField = value
                Me.RaisePropertyChanged("MatCat")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>  _
        Public Property Mtart() As String
            Get
                Return Me.mtartField
            End Get
            Set
                Me.mtartField = value
                Me.RaisePropertyChanged("Mtart")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>  _
        Public Property Maktg() As String
            Get
                Return Me.maktgField
            End Get
            Set
                Me.maktgField = value
                Me.RaisePropertyChanged("Maktg")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>  _
        Public Property Meins() As String
            Get
                Return Me.meinsField
            End Get
            Set
                Me.meinsField = value
                Me.RaisePropertyChanged("Meins")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>  _
        Public Property Matkl() As String
            Get
                Return Me.matklField
            End Get
            Set
                Me.matklField = value
                Me.RaisePropertyChanged("Matkl")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>  _
        Public Property Steuc() As String
            Get
                Return Me.steucField
            End Get
            Set
                Me.steucField = value
                Me.RaisePropertyChanged("Steuc")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=7)>  _
        Public Property TaxType() As String
            Get
                Return Me.taxTypeField
            End Get
            Set
                Me.taxTypeField = value
                Me.RaisePropertyChanged("TaxType")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style")>  _
    Partial Public Class ZfmSpuMaterialsResponse
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private etMaterialsField() As ZspuMaterial
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0),  _
         System.Xml.Serialization.XmlArrayItemAttribute("item", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property EtMaterials() As ZspuMaterial()
            Get
                Return Me.etMaterialsField
            End Get
            Set
                Me.etMaterialsField = value
                Me.RaisePropertyChanged("EtMaterials")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ZfmSpuMaterialsRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style", Order:=0)>  _
        Public ZfmSpuMaterials As ServiceReference1.ZfmSpuMaterials
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ZfmSpuMaterials As ServiceReference1.ZfmSpuMaterials)
            MyBase.New
            Me.ZfmSpuMaterials = ZfmSpuMaterials
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ZfmSpuMaterialsResponse1
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style", Order:=0)>  _
        Public ZfmSpuMaterialsResponse As ServiceReference1.ZfmSpuMaterialsResponse
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ZfmSpuMaterialsResponse As ServiceReference1.ZfmSpuMaterialsResponse)
            MyBase.New
            Me.ZfmSpuMaterialsResponse = ZfmSpuMaterialsResponse
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ZWS_MATERIALSChannel
        Inherits ServiceReference1.ZWS_MATERIALS, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ZWS_MATERIALSClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.ZWS_MATERIALS)
        Implements ServiceReference1.ZWS_MATERIALS
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_ZWS_MATERIALS_ZfmSpuMaterials(ByVal request As ServiceReference1.ZfmSpuMaterialsRequest) As ServiceReference1.ZfmSpuMaterialsResponse1 Implements ServiceReference1.ZWS_MATERIALS.ZfmSpuMaterials
            Return MyBase.Channel.ZfmSpuMaterials(request)
        End Function
        
        Public Function ZfmSpuMaterials(ByVal ZfmSpuMaterials1 As ServiceReference1.ZfmSpuMaterials) As ServiceReference1.ZfmSpuMaterialsResponse
            Dim inValue As ServiceReference1.ZfmSpuMaterialsRequest = New ServiceReference1.ZfmSpuMaterialsRequest()
            inValue.ZfmSpuMaterials = ZfmSpuMaterials1
            Dim retVal As ServiceReference1.ZfmSpuMaterialsResponse1 = CType(Me,ServiceReference1.ZWS_MATERIALS).ZfmSpuMaterials(inValue)
            Return retVal.ZfmSpuMaterialsResponse
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_ZWS_MATERIALS_ZfmSpuMaterialsAsync(ByVal request As ServiceReference1.ZfmSpuMaterialsRequest) As System.Threading.Tasks.Task(Of ServiceReference1.ZfmSpuMaterialsResponse1) Implements ServiceReference1.ZWS_MATERIALS.ZfmSpuMaterialsAsync
            Return MyBase.Channel.ZfmSpuMaterialsAsync(request)
        End Function
        
        Public Function ZfmSpuMaterialsAsync(ByVal ZfmSpuMaterials As ServiceReference1.ZfmSpuMaterials) As System.Threading.Tasks.Task(Of ServiceReference1.ZfmSpuMaterialsResponse1)
            Dim inValue As ServiceReference1.ZfmSpuMaterialsRequest = New ServiceReference1.ZfmSpuMaterialsRequest()
            inValue.ZfmSpuMaterials = ZfmSpuMaterials
            Return CType(Me,ServiceReference1.ZWS_MATERIALS).ZfmSpuMaterialsAsync(inValue)
        End Function
    End Class
End Namespace
