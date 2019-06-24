=begin
#FISSION

#Easily use IPFS from Web 2.0 applications

OpenAPI spec version: 1.0.0
Contact: support@fission.codes
Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 2.4.5

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for SwaggerClient::UserID
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'UserID' do
  before do
    # run before each test
    @instance = SwaggerClient::UserID.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of UserID' do
    it 'should create an instance of UserID' do
      expect(@instance).to be_instance_of(SwaggerClient::UserID)
    end
  end
end
