namespace CoreScripts

open UnityEngine
open System

type Hellower() =
    inherit MonoBehaviour()

    member this.Start() = Debug.Log "Hello world!"
