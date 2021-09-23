using UnityEngine;

public class playerControl : MonoBehaviour
{
    [SerializeField] private float m_Vspeed = 5.0f;
    [SerializeField] private float m_Hspeed = 5.0f;
    [SerializeField] private Rigidbody rb;
    private float m_Hpos;
    private float m_Vpos;

    private void Start() {
        rb = this.GetComponent<Rigidbody>();    
    }
    private void Update() {
        
        m_Vpos = Input.GetAxis("Vertical")*m_Vspeed*Time.deltaTime;
        m_Hpos = Input.GetAxis("Horizontal")*m_Hspeed*Time.deltaTime;

       rb.AddForce(m_Hpos,0, m_Vpos, ForceMode.Impulse);
    }
}
