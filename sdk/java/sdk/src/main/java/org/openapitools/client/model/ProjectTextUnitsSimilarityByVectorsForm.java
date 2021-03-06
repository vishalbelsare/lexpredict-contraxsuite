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
 * ProjectTextUnitsSimilarityByVectorsForm
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-05-07T11:20:07.445799+03:00[Europe/Moscow]")
public class ProjectTextUnitsSimilarityByVectorsForm {
  public static final String SERIALIZED_NAME_RUN_NAME = "run_name";
  @SerializedName(SERIALIZED_NAME_RUN_NAME)
  private String runName;

  public static final String SERIALIZED_NAME_SIMILARITY_THRESHOLD = "similarity_threshold";
  @SerializedName(SERIALIZED_NAME_SIMILARITY_THRESHOLD)
  private Integer similarityThreshold = 75;

  public static final String SERIALIZED_NAME_PROJECT = "project";
  @SerializedName(SERIALIZED_NAME_PROJECT)
  private Integer project;

  public static final String SERIALIZED_NAME_FEATURE_SOURCE = "feature_source";
  @SerializedName(SERIALIZED_NAME_FEATURE_SOURCE)
  private String featureSource = "vector";

  /**
   * Gets or Sets distanceType
   */
  @JsonAdapter(DistanceTypeEnum.Adapter.class)
  public enum DistanceTypeEnum {
    BRAYCURTIS("braycurtis"),
    
    CANBERRA("canberra"),
    
    CHEBYSHEV("chebyshev"),
    
    CITYBLOCK("cityblock"),
    
    CORRELATION("correlation"),
    
    COSINE("cosine"),
    
    DICE("dice"),
    
    EUCLIDEAN("euclidean"),
    
    HAMMING("hamming"),
    
    JACCARD("jaccard"),
    
    JENSENSHANNON("jensenshannon"),
    
    KULSINSKI("kulsinski"),
    
    MAHALANOBIS("mahalanobis"),
    
    MINKOWSKI("minkowski"),
    
    ROGERSTANIMOTO("rogerstanimoto"),
    
    RUSSELLRAO("russellrao"),
    
    SEUCLIDEAN("seuclidean"),
    
    SOKALMICHENER("sokalmichener"),
    
    SOKALSNEATH("sokalsneath"),
    
    SQEUCLIDEAN("sqeuclidean"),
    
    WMINKOWSKI("wminkowski"),
    
    YULE("yule");

    private String value;

    DistanceTypeEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static DistanceTypeEnum fromValue(String value) {
      for (DistanceTypeEnum b : DistanceTypeEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<DistanceTypeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final DistanceTypeEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public DistanceTypeEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return DistanceTypeEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_DISTANCE_TYPE = "distance_type";
  @SerializedName(SERIALIZED_NAME_DISTANCE_TYPE)
  private DistanceTypeEnum distanceType = DistanceTypeEnum.COSINE;

  public static final String SERIALIZED_NAME_ITEM_ID = "item_id";
  @SerializedName(SERIALIZED_NAME_ITEM_ID)
  private Integer itemId;

  public static final String SERIALIZED_NAME_CREATE_REVERSE_RELATIONS = "create_reverse_relations";
  @SerializedName(SERIALIZED_NAME_CREATE_REVERSE_RELATIONS)
  private Boolean createReverseRelations;

  public static final String SERIALIZED_NAME_USE_TFIDF = "use_tfidf";
  @SerializedName(SERIALIZED_NAME_USE_TFIDF)
  private Boolean useTfidf;

  public static final String SERIALIZED_NAME_DELETE = "delete";
  @SerializedName(SERIALIZED_NAME_DELETE)
  private Boolean delete;

  /**
   * Gets or Sets unitType
   */
  @JsonAdapter(UnitTypeEnum.Adapter.class)
  public enum UnitTypeEnum {
    NULL("null"),
    
    SENTENCE("sentence"),
    
    PARAGRAPH("paragraph");

    private String value;

    UnitTypeEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static UnitTypeEnum fromValue(String value) {
      for (UnitTypeEnum b : UnitTypeEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<UnitTypeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final UnitTypeEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public UnitTypeEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return UnitTypeEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_UNIT_TYPE = "unit_type";
  @SerializedName(SERIALIZED_NAME_UNIT_TYPE)
  private UnitTypeEnum unitType = UnitTypeEnum.SENTENCE;

  public static final String SERIALIZED_NAME_DOCUMENT_ID = "document_id";
  @SerializedName(SERIALIZED_NAME_DOCUMENT_ID)
  private Integer documentId;

  public static final String SERIALIZED_NAME_LOCATION_START = "location_start";
  @SerializedName(SERIALIZED_NAME_LOCATION_START)
  private Integer locationStart;

  public static final String SERIALIZED_NAME_LOCATION_END = "location_end";
  @SerializedName(SERIALIZED_NAME_LOCATION_END)
  private Integer locationEnd;


  public ProjectTextUnitsSimilarityByVectorsForm runName(String runName) {
    
    this.runName = runName;
    return this;
  }

   /**
   * Get runName
   * @return runName
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getRunName() {
    return runName;
  }


  public void setRunName(String runName) {
    this.runName = runName;
  }


  public ProjectTextUnitsSimilarityByVectorsForm similarityThreshold(Integer similarityThreshold) {
    
    this.similarityThreshold = similarityThreshold;
    return this;
  }

   /**
   * Min. Similarity Value 50-100%
   * minimum: 50
   * maximum: 100
   * @return similarityThreshold
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Min. Similarity Value 50-100%")

  public Integer getSimilarityThreshold() {
    return similarityThreshold;
  }


  public void setSimilarityThreshold(Integer similarityThreshold) {
    this.similarityThreshold = similarityThreshold;
  }


  public ProjectTextUnitsSimilarityByVectorsForm project(Integer project) {
    
    this.project = project;
    return this;
  }

   /**
   * Project with Text Unit Transformer trained model
   * @return project
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Project with Text Unit Transformer trained model")

  public Integer getProject() {
    return project;
  }


  public void setProject(Integer project) {
    this.project = project;
  }


  public ProjectTextUnitsSimilarityByVectorsForm featureSource(String featureSource) {
    
    this.featureSource = featureSource;
    return this;
  }

   /**
   * Get featureSource
   * @return featureSource
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getFeatureSource() {
    return featureSource;
  }


  public void setFeatureSource(String featureSource) {
    this.featureSource = featureSource;
  }


  public ProjectTextUnitsSimilarityByVectorsForm distanceType(DistanceTypeEnum distanceType) {
    
    this.distanceType = distanceType;
    return this;
  }

   /**
   * Get distanceType
   * @return distanceType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public DistanceTypeEnum getDistanceType() {
    return distanceType;
  }


  public void setDistanceType(DistanceTypeEnum distanceType) {
    this.distanceType = distanceType;
  }


  public ProjectTextUnitsSimilarityByVectorsForm itemId(Integer itemId) {
    
    this.itemId = itemId;
    return this;
  }

   /**
   * Optional. Search similar for one concrete text unit.
   * @return itemId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Optional. Search similar for one concrete text unit.")

  public Integer getItemId() {
    return itemId;
  }


  public void setItemId(Integer itemId) {
    this.itemId = itemId;
  }


  public ProjectTextUnitsSimilarityByVectorsForm createReverseRelations(Boolean createReverseRelations) {
    
    this.createReverseRelations = createReverseRelations;
    return this;
  }

   /**
   * Get createReverseRelations
   * @return createReverseRelations
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getCreateReverseRelations() {
    return createReverseRelations;
  }


  public void setCreateReverseRelations(Boolean createReverseRelations) {
    this.createReverseRelations = createReverseRelations;
  }


  public ProjectTextUnitsSimilarityByVectorsForm useTfidf(Boolean useTfidf) {
    
    this.useTfidf = useTfidf;
    return this;
  }

   /**
   * Get useTfidf
   * @return useTfidf
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getUseTfidf() {
    return useTfidf;
  }


  public void setUseTfidf(Boolean useTfidf) {
    this.useTfidf = useTfidf;
  }


  public ProjectTextUnitsSimilarityByVectorsForm delete(Boolean delete) {
    
    this.delete = delete;
    return this;
  }

   /**
   * Get delete
   * @return delete
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getDelete() {
    return delete;
  }


  public void setDelete(Boolean delete) {
    this.delete = delete;
  }


  public ProjectTextUnitsSimilarityByVectorsForm unitType(UnitTypeEnum unitType) {
    
    this.unitType = unitType;
    return this;
  }

   /**
   * Get unitType
   * @return unitType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public UnitTypeEnum getUnitType() {
    return unitType;
  }


  public void setUnitType(UnitTypeEnum unitType) {
    this.unitType = unitType;
  }


  public ProjectTextUnitsSimilarityByVectorsForm documentId(Integer documentId) {
    
    this.documentId = documentId;
    return this;
  }

   /**
   * Get documentId
   * @return documentId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getDocumentId() {
    return documentId;
  }


  public void setDocumentId(Integer documentId) {
    this.documentId = documentId;
  }


  public ProjectTextUnitsSimilarityByVectorsForm locationStart(Integer locationStart) {
    
    this.locationStart = locationStart;
    return this;
  }

   /**
   * Get locationStart
   * @return locationStart
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getLocationStart() {
    return locationStart;
  }


  public void setLocationStart(Integer locationStart) {
    this.locationStart = locationStart;
  }


  public ProjectTextUnitsSimilarityByVectorsForm locationEnd(Integer locationEnd) {
    
    this.locationEnd = locationEnd;
    return this;
  }

   /**
   * Get locationEnd
   * @return locationEnd
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getLocationEnd() {
    return locationEnd;
  }


  public void setLocationEnd(Integer locationEnd) {
    this.locationEnd = locationEnd;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ProjectTextUnitsSimilarityByVectorsForm projectTextUnitsSimilarityByVectorsForm = (ProjectTextUnitsSimilarityByVectorsForm) o;
    return Objects.equals(this.runName, projectTextUnitsSimilarityByVectorsForm.runName) &&
        Objects.equals(this.similarityThreshold, projectTextUnitsSimilarityByVectorsForm.similarityThreshold) &&
        Objects.equals(this.project, projectTextUnitsSimilarityByVectorsForm.project) &&
        Objects.equals(this.featureSource, projectTextUnitsSimilarityByVectorsForm.featureSource) &&
        Objects.equals(this.distanceType, projectTextUnitsSimilarityByVectorsForm.distanceType) &&
        Objects.equals(this.itemId, projectTextUnitsSimilarityByVectorsForm.itemId) &&
        Objects.equals(this.createReverseRelations, projectTextUnitsSimilarityByVectorsForm.createReverseRelations) &&
        Objects.equals(this.useTfidf, projectTextUnitsSimilarityByVectorsForm.useTfidf) &&
        Objects.equals(this.delete, projectTextUnitsSimilarityByVectorsForm.delete) &&
        Objects.equals(this.unitType, projectTextUnitsSimilarityByVectorsForm.unitType) &&
        Objects.equals(this.documentId, projectTextUnitsSimilarityByVectorsForm.documentId) &&
        Objects.equals(this.locationStart, projectTextUnitsSimilarityByVectorsForm.locationStart) &&
        Objects.equals(this.locationEnd, projectTextUnitsSimilarityByVectorsForm.locationEnd);
  }

  @Override
  public int hashCode() {
    return Objects.hash(runName, similarityThreshold, project, featureSource, distanceType, itemId, createReverseRelations, useTfidf, delete, unitType, documentId, locationStart, locationEnd);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ProjectTextUnitsSimilarityByVectorsForm {\n");
    sb.append("    runName: ").append(toIndentedString(runName)).append("\n");
    sb.append("    similarityThreshold: ").append(toIndentedString(similarityThreshold)).append("\n");
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    featureSource: ").append(toIndentedString(featureSource)).append("\n");
    sb.append("    distanceType: ").append(toIndentedString(distanceType)).append("\n");
    sb.append("    itemId: ").append(toIndentedString(itemId)).append("\n");
    sb.append("    createReverseRelations: ").append(toIndentedString(createReverseRelations)).append("\n");
    sb.append("    useTfidf: ").append(toIndentedString(useTfidf)).append("\n");
    sb.append("    delete: ").append(toIndentedString(delete)).append("\n");
    sb.append("    unitType: ").append(toIndentedString(unitType)).append("\n");
    sb.append("    documentId: ").append(toIndentedString(documentId)).append("\n");
    sb.append("    locationStart: ").append(toIndentedString(locationStart)).append("\n");
    sb.append("    locationEnd: ").append(toIndentedString(locationEnd)).append("\n");
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

