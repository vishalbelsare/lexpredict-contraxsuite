
# Org.OpenAPITools.Model.TextUnitSimilarityByFeaturesForm

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunName** | **string** |  | [optional] 
**SimilarityThreshold** | **int?** | Min. Similarity Value 50-100% | [optional] [default to 75]
**Project** | **int** |  | 
**FeatureSource** | **string** | Cluster by terms, parties or other fields. | [optional] [default to FeatureSourceEnum.Term]
**DistanceType** | **string** |  | [optional] [default to DistanceTypeEnum.Cosine]
**ItemId** | **int?** | Optional. Search similar for one concrete text unit. | [optional] 
**CreateReverseRelations** | **bool?** |  | [optional] 
**UseTfidf** | **bool?** |  | [optional] 
**Delete** | **bool?** |  | [optional] 
**UnitType** | **string** |  | [optional] [default to UnitTypeEnum.Sentence]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

