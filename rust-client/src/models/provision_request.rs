/* 
 * FISSION
 *
 * Easily use IPFS from Web 2.0 applications
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@fission.codes
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

/// ProvisionRequest : Request from Heroku to provision a new user

#[allow(unused_imports)]
use serde_json::Value;

#[derive(Debug, Serialize, Deserialize)]
pub struct ProvisionRequest {
  #[serde(rename = "callbackUrl")]
  callback_url: String,
  #[serde(rename = "name")]
  name: String,
  #[serde(rename = "plan")]
  plan: ::models::Tier,
  #[serde(rename = "region")]
  region: ::models::Region,
  #[serde(rename = "uuid")]
  uuid: String
}

impl ProvisionRequest {
  /// Request from Heroku to provision a new user
  pub fn new(callback_url: String, name: String, plan: ::models::Tier, region: ::models::Region, uuid: String) -> ProvisionRequest {
    ProvisionRequest {
      callback_url: callback_url,
      name: name,
      plan: plan,
      region: region,
      uuid: uuid
    }
  }

  pub fn set_callback_url(&mut self, callback_url: String) {
    self.callback_url = callback_url;
  }

  pub fn with_callback_url(mut self, callback_url: String) -> ProvisionRequest {
    self.callback_url = callback_url;
    self
  }

  pub fn callback_url(&self) -> &String {
    &self.callback_url
  }


  pub fn set_name(&mut self, name: String) {
    self.name = name;
  }

  pub fn with_name(mut self, name: String) -> ProvisionRequest {
    self.name = name;
    self
  }

  pub fn name(&self) -> &String {
    &self.name
  }


  pub fn set_plan(&mut self, plan: ::models::Tier) {
    self.plan = plan;
  }

  pub fn with_plan(mut self, plan: ::models::Tier) -> ProvisionRequest {
    self.plan = plan;
    self
  }

  pub fn plan(&self) -> &::models::Tier {
    &self.plan
  }


  pub fn set_region(&mut self, region: ::models::Region) {
    self.region = region;
  }

  pub fn with_region(mut self, region: ::models::Region) -> ProvisionRequest {
    self.region = region;
    self
  }

  pub fn region(&self) -> &::models::Region {
    &self.region
  }


  pub fn set_uuid(&mut self, uuid: String) {
    self.uuid = uuid;
  }

  pub fn with_uuid(mut self, uuid: String) -> ProvisionRequest {
    self.uuid = uuid;
    self
  }

  pub fn uuid(&self) -> &String {
    &self.uuid
  }


}



