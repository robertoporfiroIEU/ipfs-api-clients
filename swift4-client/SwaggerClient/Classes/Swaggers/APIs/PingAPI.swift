//
// PingAPI.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation
import Alamofire



open class PingAPI {
    /**

     - parameter completion: completion handler to receive the data and the error objects
     */
    open class func pingGet(completion: @escaping ((_ data: Pong?,_ error: Error?) -> Void)) {
        pingGetWithRequestBuilder().execute { (response, error) -> Void in
            completion(response?.body, error)
        }
    }


    /**
     - GET /ping
     - examples: [{contentType=application/json;charset=utf-8, example="pong"}]

     - returns: RequestBuilder<Pong> 
     */
    open class func pingGetWithRequestBuilder() -> RequestBuilder<Pong> {
        let path = "/ping"
        let URLString = SwaggerClientAPI.basePath + path
        let parameters: [String:Any]? = nil
        
        let url = URLComponents(string: URLString)

        let requestBuilder: RequestBuilder<Pong>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

        return requestBuilder.init(method: "GET", URLString: (url?.string ?? URLString), parameters: parameters, isBody: false)
    }

}