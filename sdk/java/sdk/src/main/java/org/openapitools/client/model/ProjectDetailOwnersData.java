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
import java.util.ArrayList;
import java.util.List;

/**
 * ProjectDetailOwnersData
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-05-07T11:20:07.445799+03:00[Europe/Moscow]")
public class ProjectDetailOwnersData {
  public static final String SERIALIZED_NAME_ID = "id";
  @SerializedName(SERIALIZED_NAME_ID)
  private Integer id;

  public static final String SERIALIZED_NAME_USERNAME = "username";
  @SerializedName(SERIALIZED_NAME_USERNAME)
  private String username;

  public static final String SERIALIZED_NAME_LAST_NAME = "last_name";
  @SerializedName(SERIALIZED_NAME_LAST_NAME)
  private String lastName;

  public static final String SERIALIZED_NAME_FIRST_NAME = "first_name";
  @SerializedName(SERIALIZED_NAME_FIRST_NAME)
  private String firstName;

  public static final String SERIALIZED_NAME_EMAIL = "email";
  @SerializedName(SERIALIZED_NAME_EMAIL)
  private String email;

  public static final String SERIALIZED_NAME_IS_SUPERUSER = "is_superuser";
  @SerializedName(SERIALIZED_NAME_IS_SUPERUSER)
  private Boolean isSuperuser;

  public static final String SERIALIZED_NAME_IS_STAFF = "is_staff";
  @SerializedName(SERIALIZED_NAME_IS_STAFF)
  private Boolean isStaff;

  public static final String SERIALIZED_NAME_IS_ACTIVE = "is_active";
  @SerializedName(SERIALIZED_NAME_IS_ACTIVE)
  private Boolean isActive;

  public static final String SERIALIZED_NAME_NAME = "name";
  @SerializedName(SERIALIZED_NAME_NAME)
  private String name;

  public static final String SERIALIZED_NAME_ORGANIZATION = "organization";
  @SerializedName(SERIALIZED_NAME_ORGANIZATION)
  private String organization;

  public static final String SERIALIZED_NAME_PHOTO = "photo";
  @SerializedName(SERIALIZED_NAME_PHOTO)
  private String photo;

  public static final String SERIALIZED_NAME_PERMISSIONS = "permissions";
  @SerializedName(SERIALIZED_NAME_PERMISSIONS)
  private Object permissions;

  public static final String SERIALIZED_NAME_GROUPS = "groups";
  @SerializedName(SERIALIZED_NAME_GROUPS)
  private List<Integer> groups = null;


   /**
   * Get id
   * @return id
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getId() {
    return id;
  }




  public ProjectDetailOwnersData username(String username) {
    
    this.username = username;
    return this;
  }

   /**
   * Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only.
   * @return username
  **/
  @ApiModelProperty(required = true, value = "Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only.")

  public String getUsername() {
    return username;
  }


  public void setUsername(String username) {
    this.username = username;
  }


  public ProjectDetailOwnersData lastName(String lastName) {
    
    this.lastName = lastName;
    return this;
  }

   /**
   * Get lastName
   * @return lastName
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getLastName() {
    return lastName;
  }


  public void setLastName(String lastName) {
    this.lastName = lastName;
  }


  public ProjectDetailOwnersData firstName(String firstName) {
    
    this.firstName = firstName;
    return this;
  }

   /**
   * Get firstName
   * @return firstName
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getFirstName() {
    return firstName;
  }


  public void setFirstName(String firstName) {
    this.firstName = firstName;
  }


  public ProjectDetailOwnersData email(String email) {
    
    this.email = email;
    return this;
  }

   /**
   * Get email
   * @return email
  **/
  @ApiModelProperty(required = true, value = "")

  public String getEmail() {
    return email;
  }


  public void setEmail(String email) {
    this.email = email;
  }


  public ProjectDetailOwnersData isSuperuser(Boolean isSuperuser) {
    
    this.isSuperuser = isSuperuser;
    return this;
  }

   /**
   * Designates that this user has all permissions without explicitly assigning them.
   * @return isSuperuser
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Designates that this user has all permissions without explicitly assigning them.")

  public Boolean getIsSuperuser() {
    return isSuperuser;
  }


  public void setIsSuperuser(Boolean isSuperuser) {
    this.isSuperuser = isSuperuser;
  }


  public ProjectDetailOwnersData isStaff(Boolean isStaff) {
    
    this.isStaff = isStaff;
    return this;
  }

   /**
   * Designates whether the user can log into this admin site.
   * @return isStaff
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Designates whether the user can log into this admin site.")

  public Boolean getIsStaff() {
    return isStaff;
  }


  public void setIsStaff(Boolean isStaff) {
    this.isStaff = isStaff;
  }


  public ProjectDetailOwnersData isActive(Boolean isActive) {
    
    this.isActive = isActive;
    return this;
  }

   /**
   * Designates whether this user should be treated as active. Unselect this instead of deleting accounts.
   * @return isActive
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Designates whether this user should be treated as active. Unselect this instead of deleting accounts.")

  public Boolean getIsActive() {
    return isActive;
  }


  public void setIsActive(Boolean isActive) {
    this.isActive = isActive;
  }


  public ProjectDetailOwnersData name(String name) {
    
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getName() {
    return name;
  }


  public void setName(String name) {
    this.name = name;
  }


  public ProjectDetailOwnersData organization(String organization) {
    
    this.organization = organization;
    return this;
  }

   /**
   * Get organization
   * @return organization
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getOrganization() {
    return organization;
  }


  public void setOrganization(String organization) {
    this.organization = organization;
  }


   /**
   * Get photo
   * @return photo
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getPhoto() {
    return photo;
  }




   /**
   * Get permissions
   * @return permissions
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Object getPermissions() {
    return permissions;
  }




  public ProjectDetailOwnersData groups(List<Integer> groups) {
    
    this.groups = groups;
    return this;
  }

  public ProjectDetailOwnersData addGroupsItem(Integer groupsItem) {
    if (this.groups == null) {
      this.groups = new ArrayList<Integer>();
    }
    this.groups.add(groupsItem);
    return this;
  }

   /**
   * The groups this user belongs to. A user will get all permissions granted to each of their groups.
   * @return groups
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "The groups this user belongs to. A user will get all permissions granted to each of their groups.")

  public List<Integer> getGroups() {
    return groups;
  }


  public void setGroups(List<Integer> groups) {
    this.groups = groups;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ProjectDetailOwnersData projectDetailOwnersData = (ProjectDetailOwnersData) o;
    return Objects.equals(this.id, projectDetailOwnersData.id) &&
        Objects.equals(this.username, projectDetailOwnersData.username) &&
        Objects.equals(this.lastName, projectDetailOwnersData.lastName) &&
        Objects.equals(this.firstName, projectDetailOwnersData.firstName) &&
        Objects.equals(this.email, projectDetailOwnersData.email) &&
        Objects.equals(this.isSuperuser, projectDetailOwnersData.isSuperuser) &&
        Objects.equals(this.isStaff, projectDetailOwnersData.isStaff) &&
        Objects.equals(this.isActive, projectDetailOwnersData.isActive) &&
        Objects.equals(this.name, projectDetailOwnersData.name) &&
        Objects.equals(this.organization, projectDetailOwnersData.organization) &&
        Objects.equals(this.photo, projectDetailOwnersData.photo) &&
        Objects.equals(this.permissions, projectDetailOwnersData.permissions) &&
        Objects.equals(this.groups, projectDetailOwnersData.groups);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, username, lastName, firstName, email, isSuperuser, isStaff, isActive, name, organization, photo, permissions, groups);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ProjectDetailOwnersData {\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    username: ").append(toIndentedString(username)).append("\n");
    sb.append("    lastName: ").append(toIndentedString(lastName)).append("\n");
    sb.append("    firstName: ").append(toIndentedString(firstName)).append("\n");
    sb.append("    email: ").append(toIndentedString(email)).append("\n");
    sb.append("    isSuperuser: ").append(toIndentedString(isSuperuser)).append("\n");
    sb.append("    isStaff: ").append(toIndentedString(isStaff)).append("\n");
    sb.append("    isActive: ").append(toIndentedString(isActive)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    organization: ").append(toIndentedString(organization)).append("\n");
    sb.append("    photo: ").append(toIndentedString(photo)).append("\n");
    sb.append("    permissions: ").append(toIndentedString(permissions)).append("\n");
    sb.append("    groups: ").append(toIndentedString(groups)).append("\n");
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

