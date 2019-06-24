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
package io.swagger.client.apis

import io.swagger.client.models.Pong

import io.swagger.client.infrastructure.*

class PingApi(basePath: kotlin.String = "https://hostless.dev") : ApiClient(basePath) {

    /**
    * 
    * 
    * @return Pong
    */
    @Suppress("UNCHECKED_CAST")
    fun pingGet() : Pong {
        val localVariableBody: kotlin.Any? = null
        val localVariableQuery: MultiValueMap = mapOf()
        
        val contentHeaders: kotlin.collections.Map<kotlin.String,kotlin.String> = mapOf()
        val acceptsHeaders: kotlin.collections.Map<kotlin.String,kotlin.String> = mapOf("Accept" to "application/json;charset&#x3D;utf-8, text/plain;charset&#x3D;utf-8")
        val localVariableHeaders: kotlin.collections.MutableMap<kotlin.String,kotlin.String> = mutableMapOf()
        localVariableHeaders.putAll(contentHeaders)
        localVariableHeaders.putAll(acceptsHeaders)
        
        val localVariableConfig = RequestConfig(
            RequestMethod.GET,
            "/ping",
            query = localVariableQuery,
            headers = localVariableHeaders
        )
        val response = request<Pong>(
            localVariableConfig,
            localVariableBody
        )

        return when (response.responseType) {
            ResponseType.Success -> (response as Success<*>).data as Pong
            ResponseType.Informational -> TODO()
            ResponseType.Redirection -> TODO()
            ResponseType.ClientError -> throw ClientException((response as ClientError<*>).body as? String ?: "Client error")
            ResponseType.ServerError -> throw ServerException((response as ServerError<*>).message ?: "Server error")
            else -> throw kotlin.IllegalStateException("Undefined ResponseType.")
        }
    }

}
