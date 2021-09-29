using System.Security.AccessControl;
using System.Runtime.InteropServices.ComTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerNew : MonoBehaviour
{
    // Start is called before the first frame update
    InputActionsAsset controls;
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private Rigidbody _rigidbody;

    private void Awake()
    {
        controls = new InputActionsAsset();//Initialize the new inputActionMap object
        controls.Player.Move.performed += ctx => Move(controls.Player.Move.ReadValue<Vector2>());
    }
    private void OnEnable()
    {
        controls.Player.Enable();
    }
    private void OnDisable()
    {
        controls.Player.Disable();
    }
    private void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
    }
    void Move(Vector2 inputs)
    {
        Vector3 movement = new Vector3(inputs.x, 0.0f, inputs.y);
        movement *= moveSpeed * Time.deltaTime;
        _rigidbody.AddForce(movement, ForceMode.VelocityChange);
    }
}