using UnityEngine;

public class GyroControl : MonoBehaviour
{
    float _speed = 10.0f;
    [SerializeField]
    private Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 dir = Vector3.zero;
        //we assume that device is held parallel to ground
        // home button is in right hand

        //XY plane of device is mapped onto XZ plane
        //Rotate 90 degrees around Y axis

        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        //clamp acceleration vector to unit sphere
        if(dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;
        this.transform.Translate(dir*_speed);

    }

}
