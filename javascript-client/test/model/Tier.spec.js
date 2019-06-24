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
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.FissionsIpfsApi);
  }
}(this, function(expect, FissionsIpfsApi) {
  'use strict';

  var instance;

  beforeEach(function() {
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('Tier', function() {
    it('should create an instance of Tier', function() {
      // uncomment below and update the code to test Tier
      //var instance = new FissionsIpfsApi.Tier();
      //expect(instance).to.be.a(FissionsIpfsApi.Tier);
    });

  });

}));
