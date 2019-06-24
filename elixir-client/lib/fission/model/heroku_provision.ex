# NOTE: This class is auto generated by the swagger code generator program.
# https://github.com/swagger-api/swagger-codegen.git
# Do not edit the class manually.

defmodule FISSION.Model.HerokuProvision do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :"id",
    :"config",
    :"message"
  ]

  @type t :: %__MODULE__{
    :"id" => UserId,
    :"config" => UserConfig,
    :"message" => String.t
  }
end

defimpl Poison.Decoder, for: FISSION.Model.HerokuProvision do
  import FISSION.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:"id", :struct, FISSION.Model.UserId, options)
    |> deserialize(:"config", :struct, FISSION.Model.UserConfig, options)
  end
end
