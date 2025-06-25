using UnityEngine;
using UnityEngine.InputSystem;

public class DroneController : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float droneSpeed;
    public LogicScript logic;
    public bool DroneIsAlive = true;

    private PlayerInput playerInput;
    private InputAction jumpAction;

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        jumpAction = playerInput.actions["Jump"];
    }

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (jumpAction.WasPressedThisFrame() && DroneIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * droneSpeed;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("ObstacleCollider"))
        {
            logic.gameOver();
            DroneIsAlive = false;
        }
        else if (other.gameObject.CompareTag("ScoreCollider"))
        {
            logic.addScore(1);
        }
    }
}
