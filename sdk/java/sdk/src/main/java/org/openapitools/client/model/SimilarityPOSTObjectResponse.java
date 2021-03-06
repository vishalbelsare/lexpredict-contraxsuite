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

/**
 * SimilarityPOSTObjectResponse
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-05-07T11:20:07.445799+03:00[Europe/Moscow]")
public class SimilarityPOSTObjectResponse {
  public static final String SERIALIZED_NAME_DETAIL = "detail";
  @SerializedName(SERIALIZED_NAME_DETAIL)
  private String detail;

  public static final String SERIALIZED_NAME_TASK_ID = "task_id";
  @SerializedName(SERIALIZED_NAME_TASK_ID)
  private String taskId;

  public static final String SERIALIZED_NAME_CONFIRM = "confirm";
  @SerializedName(SERIALIZED_NAME_CONFIRM)
  private Boolean confirm;


  public SimilarityPOSTObjectResponse detail(String detail) {
    
    this.detail = detail;
    return this;
  }

   /**
   * Get detail
   * @return detail
  **/
  @ApiModelProperty(required = true, value = "")

  public String getDetail() {
    return detail;
  }


  public void setDetail(String detail) {
    this.detail = detail;
  }


  public SimilarityPOSTObjectResponse taskId(String taskId) {
    
    this.taskId = taskId;
    return this;
  }

   /**
   * Get taskId
   * @return taskId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getTaskId() {
    return taskId;
  }


  public void setTaskId(String taskId) {
    this.taskId = taskId;
  }


  public SimilarityPOSTObjectResponse confirm(Boolean confirm) {
    
    this.confirm = confirm;
    return this;
  }

   /**
   * Get confirm
   * @return confirm
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getConfirm() {
    return confirm;
  }


  public void setConfirm(Boolean confirm) {
    this.confirm = confirm;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SimilarityPOSTObjectResponse similarityPOSTObjectResponse = (SimilarityPOSTObjectResponse) o;
    return Objects.equals(this.detail, similarityPOSTObjectResponse.detail) &&
        Objects.equals(this.taskId, similarityPOSTObjectResponse.taskId) &&
        Objects.equals(this.confirm, similarityPOSTObjectResponse.confirm);
  }

  @Override
  public int hashCode() {
    return Objects.hash(detail, taskId, confirm);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SimilarityPOSTObjectResponse {\n");
    sb.append("    detail: ").append(toIndentedString(detail)).append("\n");
    sb.append("    taskId: ").append(toIndentedString(taskId)).append("\n");
    sb.append("    confirm: ").append(toIndentedString(confirm)).append("\n");
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

