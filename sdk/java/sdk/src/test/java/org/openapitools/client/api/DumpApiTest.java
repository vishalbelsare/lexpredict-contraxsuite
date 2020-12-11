/*
 * 
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.api;

import org.openapitools.client.ApiException;
import org.openapitools.client.model.DumpFixture;
import java.io.File;
import org.openapitools.client.model.LoadFixture;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for DumpApi
 */
@Ignore
public class DumpApiTest {

    private final DumpApi api = new DumpApi();

    
    /**
     * 
     *
     * Dump document types, fields, field detectors and  document filters to json.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void dumpDocumentConfigGETTest() throws ApiException {
        Map<String, Object> response = api.dumpDocumentConfigGET();

        // TODO: test validations
    }
    
    /**
     * 
     *
     * Upload field values
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void dumpDocumentConfigPUTTest() throws ApiException {
        Map<String, Object> requestBody = null;
        File response = api.dumpDocumentConfigPUT(requestBody);

        // TODO: test validations
    }
    
    /**
     * 
     *
     * Download model fixture
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void dumpDumpFixturePOSTTest() throws ApiException {
        DumpFixture dumpFixture = null;
        File response = api.dumpDumpFixturePOST(dumpFixture);

        // TODO: test validations
    }
    
    /**
     * 
     *
     * Dump all users, roles, email addresses, review statuses, review status groups, app vars, document types, fields, field detectors and document filters to json.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void dumpDumpGETTest() throws ApiException {
        Map<String, Object> response = api.dumpDumpGET();

        // TODO: test validations
    }
    
    /**
     * 
     *
     * Upload field values
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void dumpDumpPUTTest() throws ApiException {
        Map<String, Object> requestBody = null;
        File response = api.dumpDumpPUT(requestBody);

        // TODO: test validations
    }
    
    /**
     * 
     *
     * Download field values
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void dumpFieldValuesGETTest() throws ApiException {
        Map<String, Object> response = api.dumpFieldValuesGET();

        // TODO: test validations
    }
    
    /**
     * 
     *
     * Upload field values
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void dumpFieldValuesPUTTest() throws ApiException {
        Map<String, Object> requestBody = null;
        File response = api.dumpFieldValuesPUT(requestBody);

        // TODO: test validations
    }
    
    /**
     * 
     *
     * Install model fixtures
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void dumpLoadFixturePOSTTest() throws ApiException {
        LoadFixture loadFixture = null;
        Map<String, Object> response = api.dumpLoadFixturePOST(loadFixture);

        // TODO: test validations
    }
    
}