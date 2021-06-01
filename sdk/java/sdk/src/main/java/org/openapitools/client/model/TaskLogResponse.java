/*
 * Contraxsuite API
 * Contraxsuite API
 *
 * The version of the OpenAPI document: 2.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import org.openapitools.client.model.TaskLogResponseRecords;

/**
 * TaskLogResponse
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-05-07T11:20:07.445799+03:00[Europe/Moscow]")
public class TaskLogResponse {
  public static final String SERIALIZED_NAME_RECORDS = "records";
  @SerializedName(SERIALIZED_NAME_RECORDS)
  private TaskLogResponseRecords records;

  public static final String SERIALIZED_NAME_TOTAL_RECORDS_COUNT = "total_records_count";
  @SerializedName(SERIALIZED_NAME_TOTAL_RECORDS_COUNT)
  private Integer totalRecordsCount;

  public static final String SERIALIZED_NAME_FILTERED_RECORDS_COUNT = "filtered_records_count";
  @SerializedName(SERIALIZED_NAME_FILTERED_RECORDS_COUNT)
  private Integer filteredRecordsCount;

  public static final String SERIALIZED_NAME_CURRENT_RECORDS_COUNT = "current_records_count";
  @SerializedName(SERIALIZED_NAME_CURRENT_RECORDS_COUNT)
  private Integer currentRecordsCount;


  public TaskLogResponse records(TaskLogResponseRecords records) {
    
    this.records = records;
    return this;
  }

   /**
   * Get records
   * @return records
  **/
  @ApiModelProperty(required = true, value = "")

  public TaskLogResponseRecords getRecords() {
    return records;
  }


  public void setRecords(TaskLogResponseRecords records) {
    this.records = records;
  }


  public TaskLogResponse totalRecordsCount(Integer totalRecordsCount) {
    
    this.totalRecordsCount = totalRecordsCount;
    return this;
  }

   /**
   * Get totalRecordsCount
   * @return totalRecordsCount
  **/
  @ApiModelProperty(required = true, value = "")

  public Integer getTotalRecordsCount() {
    return totalRecordsCount;
  }


  public void setTotalRecordsCount(Integer totalRecordsCount) {
    this.totalRecordsCount = totalRecordsCount;
  }


  public TaskLogResponse filteredRecordsCount(Integer filteredRecordsCount) {
    
    this.filteredRecordsCount = filteredRecordsCount;
    return this;
  }

   /**
   * Get filteredRecordsCount
   * @return filteredRecordsCount
  **/
  @ApiModelProperty(required = true, value = "")

  public Integer getFilteredRecordsCount() {
    return filteredRecordsCount;
  }


  public void setFilteredRecordsCount(Integer filteredRecordsCount) {
    this.filteredRecordsCount = filteredRecordsCount;
  }


  public TaskLogResponse currentRecordsCount(Integer currentRecordsCount) {
    
    this.currentRecordsCount = currentRecordsCount;
    return this;
  }

   /**
   * Get currentRecordsCount
   * @return currentRecordsCount
  **/
  @ApiModelProperty(required = true, value = "")

  public Integer getCurrentRecordsCount() {
    return currentRecordsCount;
  }


  public void setCurrentRecordsCount(Integer currentRecordsCount) {
    this.currentRecordsCount = currentRecordsCount;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TaskLogResponse taskLogResponse = (TaskLogResponse) o;
    return Objects.equals(this.records, taskLogResponse.records) &&
        Objects.equals(this.totalRecordsCount, taskLogResponse.totalRecordsCount) &&
        Objects.equals(this.filteredRecordsCount, taskLogResponse.filteredRecordsCount) &&
        Objects.equals(this.currentRecordsCount, taskLogResponse.currentRecordsCount);
  }

  @Override
  public int hashCode() {
    return Objects.hash(records, totalRecordsCount, filteredRecordsCount, currentRecordsCount);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TaskLogResponse {\n");
    sb.append("    records: ").append(toIndentedString(records)).append("\n");
    sb.append("    totalRecordsCount: ").append(toIndentedString(totalRecordsCount)).append("\n");
    sb.append("    filteredRecordsCount: ").append(toIndentedString(filteredRecordsCount)).append("\n");
    sb.append("    currentRecordsCount: ").append(toIndentedString(currentRecordsCount)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
