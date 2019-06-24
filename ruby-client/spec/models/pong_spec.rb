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

# Unit tests for SwaggerClient::Pong
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'Pong' do
  before do
    # run before each test
    @instance = SwaggerClient::Pong.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of Pong' do
    it 'should create an instance of Pong' do
      expect(@instance).to be_instance_of(SwaggerClient::Pong)
    end
  end
end
