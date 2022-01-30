namespace CoreScripts

open UnityEngine
open System

type ColaBottleMovement() as this =
    inherit MonoBehaviour()

    [<SerializeField>]
    let _thrustSpeed = 1000f

    [<SerializeField>]
    let _rotationSpeed = 250f

    let mutable _rigidBody: Rigidbody = null

    let applyRotation (direction: Vector3) =
        _rigidBody.freezeRotation <- true
        this.transform.Rotate (direction * _rotationSpeed * Time.deltaTime)
        _rigidBody.freezeRotation <- false

    let processInput () =
        if Input.GetKey KeyCode.Space then
            _rigidBody.AddRelativeForce (Vector3.up * _thrustSpeed * Time.deltaTime)

        if Input.GetKey KeyCode.A then
            applyRotation Vector3.forward
        else if Input.GetKey KeyCode.D then
            applyRotation Vector3.back

    member this.Start() =
        _rigidBody <- this.GetComponent<Rigidbody>()

    member this.Update() = processInput ()
