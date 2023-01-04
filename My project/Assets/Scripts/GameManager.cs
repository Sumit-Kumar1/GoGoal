using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject GameObjectBall;
    [SerializeField]
    private GameObject Maze;

    [SerializeField]
    private GameObject SpawnA;
    [SerializeField]
    private GameObject SpawnB;
    [SerializeField]
    private GameObject SpawnC;
    [SerializeField]
    private GameObject SpawnD;

    [SerializeField]
    private Cinemachine.CinemachineVirtualCamera vcam;
    GameObject ball;
    private void Awake()
    {
        //ball = GameObject.Instantiate(GameObjectBall, SpawnB.transform.position, Quaternion.identity);
    }

    void Start()
    {
        //vcam.Follow = ball.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
