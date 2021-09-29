using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerNew : MonoBehaviour
{
    // Start is called before the first frame update
    InputActionsAsset controls;
    private void Awake()
    {
        controls = new InputActionsAsset();//Initialize the new inputActionMap object
        controls.Player.Move.performed += ctx => Move();
    }
    private void OnEnable()
    {
        controls.Player.Enable();
    }
    private void OnDisable()
    {
        controls.Player.Disable();
    }
}
