//
// HerokuProvision.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct HerokuProvision: Codable {

    public var _id: UserID
    public var config: UserConfig
    public var message: String?

    public init(_id: UserID, config: UserConfig, message: String?) {
        self._id = _id
        self.config = config
        self.message = message
    }

    public enum CodingKeys: String, CodingKey { 
        case _id = "id"
        case config
        case message
    }


}

