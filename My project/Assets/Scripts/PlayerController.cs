using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody rb_Player;
    [SerializeField] private Camera cam;
    [SerializeField] private float xMoveSpeed=10.0f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float x_input = Input.GetAxis("Horizontal")*xMoveSpeed;
        rb_Player.transform.Translate(x_input, 0, 0);

    }
}
