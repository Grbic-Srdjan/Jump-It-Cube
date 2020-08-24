using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    private Rigidbody2D rb;
    private bool isGrounded;
    public Transform groundCheck;
    public float chackRadius;
    public LayerMask isGroundedRealy;
    public int extraJump, numberOfJumps;
    public static int health = 4;
    public GameObject healthText; 
    public static double EnemySpeed = 5f;
    public static float SpeedCounter = 0f;
    public AudioSource JumpSoundEffect, PlayerDieSoundEffect; 

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = 4;    
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, chackRadius, isGroundedRealy);
    }
    private void Update()
    {
        if (isGrounded) extraJump = numberOfJumps;
        if ((Input.GetKey("space") || CrossPlatformInputManager.GetButtonDown("Jump") ||Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey("w")) && (extraJump > 0))
        {
            rb.velocity = Vector2.up * jumpForce;
            JumpSoundEffect.Play();
            extraJump--; 
        }
        else if ((Input.GetKey("space") || CrossPlatformInputManager.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey("w")) && (extraJump == 0) && isGrounded) rb.velocity = Vector2.up * jumpForce;
        if (health <= 0 || transform.position.y < -53.5)
        {
            PlayerDieSoundEffect.Play();  
            SceneManager.LoadScene("GameOver");
        }
        healthText.GetComponent<Text>().text = "lives remaning: " + health;
    }
}
