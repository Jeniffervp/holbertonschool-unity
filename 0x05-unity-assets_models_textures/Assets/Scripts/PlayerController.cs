using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float jumpForce = 5f;
    public float speed = 12f;
    public float gravity = -20f;
    Transform playerPosition;
    Vector3 velocity;
    void Start()
    {
        playerPosition = GetComponent<Transform>();
    }
    public void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        if (controller.isGrounded && velocity.y < 0)
            velocity.y = -2f;
        if (controller.isGrounded && Input.GetButtonDown("Jump"))
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);

        Vector3 direction = (transform.right * moveHorizontal) + (transform.forward * moveVertical);

        controller.Move(direction * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (playerPosition.position.y < -30f)
            playerPosition.position = new Vector3(0, 50, 0);
    }
}
