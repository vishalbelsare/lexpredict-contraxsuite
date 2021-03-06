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
 * DocumentSimilarityByFeaturesForm
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-05-07T11:20:07.445799+03:00[Europe/Moscow]")
public class DocumentSimilarityByFeaturesForm {
  public static final String SERIALIZED_NAME_RUN_NAME = "run_name";
  @SerializedName(SERIALIZED_NAME_RUN_NAME)
  private String runName;

  public static final String SERIALIZED_NAME_SIMILARITY_THRESHOLD = "similarity_threshold";
  @SerializedName(SERIALIZED_NAME_SIMILARITY_THRESHOLD)
  private Integer similarityThreshold = 75;

  public static final String SERIALIZED_NAME_PROJECT = "project";
  @SerializedName(SERIALIZED_NAME_PROJECT)
  private Integer project;

  /**
   * Cluster by terms, parties or other fields.
   */
  @JsonAdapter(FeatureSourceEnum.Adapter.class)
  public enum FeatureSourceEnum {
    DATE("date"),
    
    DEFINITION("definition"),
    
    DURATION("duration"),
    
    COURT("court"),
    
    CURRENCY_NAME("currency_name"),
    
    CURRENCY_VALUE("currency_value"),
    
    TERM("term"),
    
    PARTY("party"),
    
    GEOENTITY("geoentity");

    private String value;

    FeatureSourceEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static FeatureSourceEnum fromValue(String value) {
      for (FeatureSourceEnum b : FeatureSourceEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<FeatureSourceEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final FeatureSourceEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public FeatureSourceEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return FeatureSourceEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_FEATURE_SOURCE = "feature_source";
  @SerializedName(SERIALIZED_NAME_FEATURE_SOURCE)
  private FeatureSourceEnum featureSource = FeatureSourceEnum.TERM;

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


  public DocumentSimilarityByFeaturesForm runName(String runName) {
    
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


  public DocumentSimilarityByFeaturesForm similarityThreshold(Integer similarityThreshold) {
    
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


  public DocumentSimilarityByFeaturesForm project(Integer project) {
    
    this.project = project;
    return this;
  }

   /**
   * Get project
   * @return project
  **/
  @ApiModelProperty(required = true, value = "")

  public Integer getProject() {
    return project;
  }


  public void setProject(Integer project) {
    this.project = project;
  }


  public DocumentSimilarityByFeaturesForm featureSource(FeatureSourceEnum featureSource) {
    
    this.featureSource = featureSource;
    return this;
  }

   /**
   * Cluster by terms, parties or other fields.
   * @return featureSource
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Cluster by terms, parties or other fields.")

  public FeatureSourceEnum getFeatureSource() {
    return featureSource;
  }


  public void setFeatureSource(FeatureSourceEnum featureSource) {
    this.featureSource = featureSource;
  }


  public DocumentSimilarityByFeaturesForm distanceType(DistanceTypeEnum distanceType) {
    
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


  public DocumentSimilarityByFeaturesForm itemId(Integer itemId) {
    
    this.itemId = itemId;
    return this;
  }

   /**
   * Optional. Search similar for one concrete document
   * @return itemId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Optional. Search similar for one concrete document")

  public Integer getItemId() {
    return itemId;
  }


  public void setItemId(Integer itemId) {
    this.itemId = itemId;
  }


  public DocumentSimilarityByFeaturesForm createReverseRelations(Boolean createReverseRelations) {
    
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


  public DocumentSimilarityByFeaturesForm useTfidf(Boolean useTfidf) {
    
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


  public DocumentSimilarityByFeaturesForm delete(Boolean delete) {
    
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


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocumentSimilarityByFeaturesForm documentSimilarityByFeaturesForm = (DocumentSimilarityByFeaturesForm) o;
    return Objects.equals(this.runName, documentSimilarityByFeaturesForm.runName) &&
        Objects.equals(this.similarityThreshold, documentSimilarityByFeaturesForm.similarityThreshold) &&
        Objects.equals(this.project, documentSimilarityByFeaturesForm.project) &&
        Objects.equals(this.featureSource, documentSimilarityByFeaturesForm.featureSource) &&
        Objects.equals(this.distanceType, documentSimilarityByFeaturesForm.distanceType) &&
        Objects.equals(this.itemId, documentSimilarityByFeaturesForm.itemId) &&
        Objects.equals(this.createReverseRelations, documentSimilarityByFeaturesForm.createReverseRelations) &&
        Objects.equals(this.useTfidf, documentSimilarityByFeaturesForm.useTfidf) &&
        Objects.equals(this.delete, documentSimilarityByFeaturesForm.delete);
  }

  @Override
  public int hashCode() {
    return Objects.hash(runName, similarityThreshold, project, featureSource, distanceType, itemId, createReverseRelations, useTfidf, delete);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocumentSimilarityByFeaturesForm {\n");
    sb.append("    runName: ").append(toIndentedString(runName)).append("\n");
    sb.append("    similarityThreshold: ").append(toIndentedString(similarityThreshold)).append("\n");
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    featureSource: ").append(toIndentedString(featureSource)).append("\n");
    sb.append("    distanceType: ").append(toIndentedString(distanceType)).append("\n");
    sb.append("    itemId: ").append(toIndentedString(itemId)).append("\n");
    sb.append("    createReverseRelations: ").append(toIndentedString(createReverseRelations)).append("\n");
    sb.append("    useTfidf: ").append(toIndentedString(useTfidf)).append("\n");
    sb.append("    delete: ").append(toIndentedString(delete)).append("\n");
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

