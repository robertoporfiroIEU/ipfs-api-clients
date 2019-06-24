# Go API client for swagger

Easily use IPFS from Web 2.0 applications

## Overview
This API client was generated by the [swagger-codegen](https://github.com/swagger-api/swagger-codegen) project.  By using the [swagger-spec](https://github.com/swagger-api/swagger-spec) from a remote server, you can easily generate an API client.

- API version: 1.0.0
- Package version: 1.0.0
- Build package: io.swagger.codegen.languages.GoClientCodegen
For more information, please visit [https://fission.codes](https://fission.codes)

## Installation
Put the package under your project folder and add the following in import:
```golang
import "./swagger"
```

## Documentation for API Endpoints

All URIs are relative to *https://hostless.dev*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*HerokuApi* | [**HerokuResourcesPost**](docs/HerokuApi.md#herokuresourcespost) | **Post** /heroku/resources | 
*IPFSApi* | [**IpfsPeersGet**](docs/IPFSApi.md#ipfspeersget) | **Get** /ipfs/peers | 
*IPFSApi* | [**IpfsPost**](docs/IPFSApi.md#ipfspost) | **Post** /ipfs | 
*PingApi* | [**PingGet**](docs/PingApi.md#pingget) | **Get** /ping | 


## Documentation For Models

 - [HerokuProvision](docs/HerokuProvision.md)
 - [IpfsAddress](docs/IpfsAddress.md)
 - [IpfsPeer](docs/IpfsPeer.md)
 - [Pong](docs/Pong.md)
 - [ProvisionRequest](docs/ProvisionRequest.md)
 - [Region](docs/Region.md)
 - [Secret](docs/Secret.md)
 - [SerializedFile](docs/SerializedFile.md)
 - [Tier](docs/Tier.md)
 - [UserConfig](docs/UserConfig.md)
 - [UserId](docs/UserId.md)
 - [Uuid](docs/Uuid.md)


## Documentation For Authorization

## basic
- **Type**: HTTP basic authentication

Example
```golang
auth := context.WithValue(context.Background(), sw.ContextBasicAuth, sw.BasicAuth{
	UserName: "username",
	Password: "password",
})
r, err := client.Service.Operation(auth, args)
```

## Author

support@fission.codes
