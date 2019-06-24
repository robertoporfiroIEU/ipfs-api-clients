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

# Unit tests for SwaggerClient::HerokuApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'HerokuApi' do
  before do
    # run before each test
    @instance = SwaggerClient::HerokuApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of HerokuApi' do
    it 'should create an instance of HerokuApi' do
      expect(@instance).to be_instance_of(SwaggerClient::HerokuApi)
    end
  end

  # unit tests for heroku_resources_post
  # @param body 
  # @param [Hash] opts the optional parameters
  # @return [HerokuProvision]
  describe 'heroku_resources_post test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
