/**
* FISSION
* Easily use IPFS from Web 2.0 applications
*
* OpenAPI spec version: 1.0.0
* Contact: support@fission.codes
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*/
package io.swagger.client.models


import com.squareup.moshi.Json

/**
* 
* Values: california,dublin,frankfurt,oregon,singapore,sydney,tokyo,virginia
*/
enum class Region(val value: kotlin.String){

    @Json(name = "california") california("california"),

    @Json(name = "dublin") dublin("dublin"),

    @Json(name = "frankfurt") frankfurt("frankfurt"),

    @Json(name = "oregon") oregon("oregon"),

    @Json(name = "singapore") singapore("singapore"),

    @Json(name = "sydney") sydney("sydney"),

    @Json(name = "tokyo") tokyo("tokyo"),

    @Json(name = "virginia") virginia("virginia");

}
