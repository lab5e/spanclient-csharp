# spanclient.Model.Collection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionId** | **string** | The ID of the collection. This is assigned by the backend. | [optional] 
**TeamId** | **string** | The team ID that owns the collection. This field is required. When you create new collections the default is to use your private team ID. | [optional] 
**FieldMask** | [**FieldMask**](FieldMask.md) |  | [optional] 
**Firmware** | [**CollectionFirmware**](CollectionFirmware.md) |  | [optional] 
**Tags** | **Dictionary&lt;string, string&gt;** | Tags for the collection. Tags are metadata fields that you can assign to the collection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

