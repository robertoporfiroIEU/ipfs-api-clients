/**
 * FISSION's IPFS API
 * Easily use IPFS from Web 2.0 applications
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@fission.codes
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.5
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/Region', 'model/Tier'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./Region'), require('./Tier'));
  } else {
    // Browser globals (root is window)
    if (!root.FissionsIpfsApi) {
      root.FissionsIpfsApi = {};
    }
    root.FissionsIpfsApi.ProvisionRequest = factory(root.FissionsIpfsApi.ApiClient, root.FissionsIpfsApi.Region, root.FissionsIpfsApi.Tier);
  }
}(this, function(ApiClient, Region, Tier) {
  'use strict';




  /**
   * The ProvisionRequest model module.
   * @module model/ProvisionRequest
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>ProvisionRequest</code>.
   * Request from Heroku to provision a new user
   * @alias module:model/ProvisionRequest
   * @class
   * @param callbackUrl {String} 
   * @param name {String} 
   * @param plan {module:model/Tier} 
   * @param region {module:model/Region} 
   * @param uuid {String} 
   */
  var exports = function(callbackUrl, name, plan, region, uuid) {
    var _this = this;

    _this['callbackUrl'] = callbackUrl;
    _this['name'] = name;
    _this['plan'] = plan;
    _this['region'] = region;
    _this['uuid'] = uuid;
  };

  /**
   * Constructs a <code>ProvisionRequest</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ProvisionRequest} obj Optional instance to populate.
   * @return {module:model/ProvisionRequest} The populated <code>ProvisionRequest</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('callbackUrl')) {
        obj['callbackUrl'] = ApiClient.convertToType(data['callbackUrl'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('plan')) {
        obj['plan'] = Tier.constructFromObject(data['plan']);
      }
      if (data.hasOwnProperty('region')) {
        obj['region'] = Region.constructFromObject(data['region']);
      }
      if (data.hasOwnProperty('uuid')) {
        obj['uuid'] = ApiClient.convertToType(data['uuid'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {String} callbackUrl
   */
  exports.prototype['callbackUrl'] = undefined;
  /**
   * @member {String} name
   */
  exports.prototype['name'] = undefined;
  /**
   * @member {module:model/Tier} plan
   */
  exports.prototype['plan'] = undefined;
  /**
   * @member {module:model/Region} region
   */
  exports.prototype['region'] = undefined;
  /**
   * @member {String} uuid
   */
  exports.prototype['uuid'] = undefined;



  return exports;
}));


