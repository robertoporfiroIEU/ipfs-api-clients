# NOTE: This class is auto generated by the swagger code generator program.
# https://github.com/swagger-api/swagger-codegen.git
# Do not edit the class manually.

defmodule FISSION.Model.IpfsPeer do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    
  ]

  @type t :: %__MODULE__{
    
  }
end

defimpl Poison.Decoder, for: FISSION.Model.IpfsPeer do
  def decode(value, _options) do
    value
  end
end
