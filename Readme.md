<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576688/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T361375)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RequestDataLoadingExample/Form1.cs) (VB: [Form1.vb](./VB/RequestDataLoadingExample/Form1.vb))
<!-- default file list end -->
# How to monitor a service request state


This example demonstrates how to monitor the service request state.


<h3>Description</h3>

<p>To do this, handle the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapImageLayer_RequestDataLoadingtopic">ImageLayer.RequestDataLoading</a>&nbsp;event. Specify the wait form&nbsp;which will be shown when data is loading. Handle the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLayerBase_DataLoadedtopic">LayerBase.DataLoaded</a>&nbsp;event to determine the state of the wait form&nbsp;after&nbsp;map data was&nbsp;obtained.</p>

<br/>


