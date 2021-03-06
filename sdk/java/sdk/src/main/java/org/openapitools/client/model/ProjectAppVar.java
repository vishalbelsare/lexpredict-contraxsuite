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
 * ProjectAppVar
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-05-07T11:20:07.445799+03:00[Europe/Moscow]")
public class ProjectAppVar {
  public static final String SERIALIZED_NAME_CATEGORY = "category";
  @SerializedName(SERIALIZED_NAME_CATEGORY)
  private String category;

  public static final String SERIALIZED_NAME_NAME = "name";
  @SerializedName(SERIALIZED_NAME_NAME)
  private String name;

  public static final String SERIALIZED_NAME_DESCRIPTION = "description";
  @SerializedName(SERIALIZED_NAME_DESCRIPTION)
  private String description;

  public static final String SERIALIZED_NAME_VALUE = "value";
  @SerializedName(SERIALIZED_NAME_VALUE)
  private Object value;

  public static final String SERIALIZED_NAME_ACCESS_TYPE = "access_type";
  @SerializedName(SERIALIZED_NAME_ACCESS_TYPE)
  private String accessType;

  public static final String SERIALIZED_NAME_USE_SYSTEM = "use_system";
  @SerializedName(SERIALIZED_NAME_USE_SYSTEM)
  private Boolean useSystem;

  public static final String SERIALIZED_NAME_SYSTEM_VALUE = "system_value";
  @SerializedName(SERIALIZED_NAME_SYSTEM_VALUE)
  private Object systemValue;


  public ProjectAppVar category(String category) {
    
    this.category = category;
    return this;
  }

   /**
   * Get category
   * @return category
  **/
  @ApiModelProperty(required = true, value = "")

  public String getCategory() {
    return category;
  }


  public void setCategory(String category) {
    this.category = category;
  }


  public ProjectAppVar name(String name) {
    
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @ApiModelProperty(required = true, value = "")

  public String getName() {
    return name;
  }


  public void setName(String name) {
    this.name = name;
  }


  public ProjectAppVar description(String description) {
    
    this.description = description;
    return this;
  }

   /**
   * Get description
   * @return description
  **/
  @ApiModelProperty(required = true, value = "")

  public String getDescription() {
    return description;
  }


  public void setDescription(String description) {
    this.description = description;
  }


  public ProjectAppVar value(Object value) {
    
    this.value = value;
    return this;
  }

   /**
   * Get value
   * @return value
  **/
  @ApiModelProperty(required = true, value = "")

  public Object getValue() {
    return value;
  }


  public void setValue(Object value) {
    this.value = value;
  }


  public ProjectAppVar accessType(String accessType) {
    
    this.accessType = accessType;
    return this;
  }

   /**
   * Get accessType
   * @return accessType
  **/
  @ApiModelProperty(required = true, value = "")

  public String getAccessType() {
    return accessType;
  }


  public void setAccessType(String accessType) {
    this.accessType = accessType;
  }


  public ProjectAppVar useSystem(Boolean useSystem) {
    
    this.useSystem = useSystem;
    return this;
  }

   /**
   * Get useSystem
   * @return useSystem
  **/
  @ApiModelProperty(required = true, value = "")

  public Boolean getUseSystem() {
    return useSystem;
  }


  public void setUseSystem(Boolean useSystem) {
    this.useSystem = useSystem;
  }


  public ProjectAppVar systemValue(Object systemValue) {
    
    this.systemValue = systemValue;
    return this;
  }

   /**
   * Get systemValue
   * @return systemValue
  **/
  @ApiModelProperty(required = true, value = "")

  public Object getSystemValue() {
    return systemValue;
  }


  public void setSystemValue(Object systemValue) {
    this.systemValue = systemValue;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ProjectAppVar projectAppVar = (ProjectAppVar) o;
    return Objects.equals(this.category, projectAppVar.category) &&
        Objects.equals(this.name, projectAppVar.name) &&
        Objects.equals(this.description, projectAppVar.description) &&
        Objects.equals(this.value, projectAppVar.value) &&
        Objects.equals(this.accessType, projectAppVar.accessType) &&
        Objects.equals(this.useSystem, projectAppVar.useSystem) &&
        Objects.equals(this.systemValue, projectAppVar.systemValue);
  }

  @Override
  public int hashCode() {
    return Objects.hash(category, name, description, value, accessType, useSystem, systemValue);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ProjectAppVar {\n");
    sb.append("    category: ").append(toIndentedString(category)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    value: ").append(toIndentedString(value)).append("\n");
    sb.append("    accessType: ").append(toIndentedString(accessType)).append("\n");
    sb.append("    useSystem: ").append(toIndentedString(useSystem)).append("\n");
    sb.append("    systemValue: ").append(toIndentedString(systemValue)).append("\n");
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

