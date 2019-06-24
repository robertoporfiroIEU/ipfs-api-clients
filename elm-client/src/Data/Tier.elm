{-
   FISSION
   Easily use IPFS from Web 2.0 applications

   OpenAPI spec version: 1.0.0
   Contact: support@fission.codes

   NOTE: This file is auto generated by the swagger code generator program.
   https://github.com/swagger-api/swagger-codegen.git
   Do not edit this file manually.
-}


module Data.Tier exposing (Tier(..), tierDecoder, tierEncoder)

import Json.Decode as Decode exposing (Decoder)
import Json.Decode.Pipeline exposing (decode, optional, required)
import Json.Encode as Encode
import Maybe exposing (map, withDefault)


type Tier
    = Test
    | Free



tierDecoder : Decoder Tier
tierDecoder =
    Decode.string
        |> Decode.andThen (\str ->
            case str of
                "test" ->
                    Decode.succeed Test

                "free" ->
                    Decode.succeed Free

                other ->
                    Decode.fail <| "Unknown type: " ++ other
        )


tierEncoder : Tier -> Encode.Value
tierEncoder model =
    case model of
        Test ->
            Encode.string "test"

        Free ->
            Encode.string "free"


