# ProjectDetail


## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **str** |  | 
**created_by_name** | **str** |  | 
**modified_by_name** | **str** |  | 
**type_data** | [**ProjectListTypeData**](ProjectListTypeData.md) |  | 
**pk** | **int** |  | [optional] [readonly] 
**description** | **str, none_type** |  | [optional] 
**created_date** | **datetime, none_type** |  | [optional] 
**modified_date** | **datetime, none_type** |  | [optional] 
**send_email_notification** | **bool** |  | [optional] 
**hide_clause_review** | **bool** |  | [optional] 
**status** | **int** |  | [optional] 
**status_data** | [**ProjectListStatusData**](ProjectListStatusData.md) |  | [optional] 
**owners** | **[int]** |  | [optional] 
**owners_data** | [**[ProjectDetailOwnersData]**](ProjectDetailOwnersData.md) |  | [optional] [readonly] 
**reviewers** | **[int]** |  | [optional] 
**reviewers_data** | [**[ProjectDetailOwnersData]**](ProjectDetailOwnersData.md) |  | [optional] [readonly] 
**super_reviewers** | **[int]** |  | [optional] 
**super_reviewers_data** | [**[ProjectDetailOwnersData]**](ProjectDetailOwnersData.md) |  | [optional] [readonly] 
**junior_reviewers** | **[int]** |  | [optional] 
**junior_reviewers_data** | [**[ProjectDetailOwnersData]**](ProjectDetailOwnersData.md) |  | [optional] [readonly] 
**type** | **str** |  | [optional] 
**progress** | **str** |  | [optional] [readonly] 
**user_permissions** | **str** |  | [optional] [readonly] 
**term_tags** | **[int]** |  | [optional] 
**document_transformer** | **int, none_type** |  | [optional] 
**text_unit_transformer** | **int, none_type** |  | [optional] 
**companytype_tags** | **[int]** |  | [optional] 
**app_vars** | **str** |  | [optional] [readonly] 
**document_similarity_run_params** | **str** |  | [optional] [readonly] 
**text_unit_similarity_run_params** | **str, none_type** |  | [optional] [readonly] 
**document_similarity_process_allowed** | **str** |  | [optional] [readonly] 
**text_unit_similarity_process_allowed** | **str** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


