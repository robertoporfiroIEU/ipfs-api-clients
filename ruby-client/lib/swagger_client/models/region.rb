=begin
#FISSION

#Easily use IPFS from Web 2.0 applications

OpenAPI spec version: 1.0.0
Contact: support@fission.codes
Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 2.4.5

=end

require 'date'

module SwaggerClient
  class Region
    
    CALIFORNIA = 'california'.freeze
    DUBLIN = 'dublin'.freeze
    FRANKFURT = 'frankfurt'.freeze
    OREGON = 'oregon'.freeze
    SINGAPORE = 'singapore'.freeze
    SYDNEY = 'sydney'.freeze
    TOKYO = 'tokyo'.freeze
    VIRGINIA = 'virginia'.freeze

    # Builds the enum from string
    # @param [String] The enum value in the form of the string
    # @return [String] The enum value
    def build_from_hash(value)
      constantValues = Region.constants.select { |c| Region::const_get(c) == value }
      raise "Invalid ENUM value #{value} for class #Region" if constantValues.empty?
      value
    end
  end
end
