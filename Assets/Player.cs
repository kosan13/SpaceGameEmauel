using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    
    [SerializeField] private InputAction playerInput;

    private Rigidbody2D _rb;
    
    public float speed = 10f;
    public float thrust = 10f;  

    public YouLostMenu lost;
    public YouWinMenu win;
    public PauseMenu pauseMenu;
    
    private static bool _playsMovementOnOff;
    
    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }

    private void Start()
    {
        _playsMovementOnOff = true;
        pauseMenu.Resume();
    }

    private void Update()
    {
        if ( _playsMovementOnOff)
        {
            PlaysMovement();
        }   
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<WallCollider>() != null )
        { 
             lost.YouLost();
        }
        _playsMovementOnOff = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<WinCollider>() != null)
        {
            win.YouWin();
            _rb.velocity = Vector2.zero;
        }
        _playsMovementOnOff = false;
        
    }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void PlaysMovement()
    {
        _rb.AddRelativeForce(-transform.right * (100 * (speed * Time.deltaTime)));

        if (Input.GetKey(KeyCode.Space))
        {
            _rb.AddRelativeForce(-transform.up * (100 * (Time.deltaTime * thrust)));
        }
    }
}
