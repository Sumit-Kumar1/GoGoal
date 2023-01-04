using UnityEngine;
using UnityEngine.InputSystem;

public class GyroControl : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;

    [SerializeField]
    private Rigidbody rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
      
        if (Screen.autorotateToLandscapeLeft)
        {
            Debug.Log("ALready landscape Left");
        }
        else
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            Debug.Log("Device Rotated by Code");
        }

    }

    void Update()
    {
        // top capture accelerometer input
        Vector3 dir = Vector3.zero;

        // normalized acceleration Input
        Vector3 dirN = Input.acceleration;
        dirN.x = -dirN.x;
        Quaternion newRotation = Quaternion.Euler((-90+dirN.x*30), 0,dirN.z*30);

        rb.rotation = Quaternion.RotateTowards(transform.rotation, newRotation, 45);
    }
}
    
