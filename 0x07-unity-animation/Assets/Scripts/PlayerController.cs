using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float gravity = -9.81f;
    public float jumpForce = 1.8f;
    Transform cameraMain;
    Transform positionPlayer;
    public float speed = 12f;
    public float turnSoftTime = 0.3f;
    float turnSoftVelocity;
    Vector3 velocity;
    void Start()
    {
        positionPlayer = GetComponent<Transform>();
        cameraMain = Camera.main.transform;
    }
    public void Update()
    {
        if (controller.isGrounded && velocity.y < 0)
            velocity.y = -2f;
        if (controller.isGrounded && Input.GetButtonDown("Jump"))
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 direct = new Vector3(moveHorizontal, 0f, moveVertical).normalized;
        if (direct.magnitude >= 0.1f)
        {
            float angTarget = Mathf.Atan2(direct.x, direct.z) * Mathf.Rad2Deg + cameraMain.eulerAngles.y;
            float ang = Mathf.SmoothDampAngle(transform.eulerAngles.y, angTarget, ref turnSoftVelocity, turnSoftTime);
            transform.rotation = Quaternion.Euler(0f, ang, 0f);
            Vector3 moveDirect = Quaternion.Euler(0f, angTarget, 0f) * Vector3.forward;
            controller.Move(moveDirect.normalized * speed * Time.deltaTime);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        if (positionPlayer.position.y < -30f)
            positionPlayer.position = new Vector3(0, 50, 0);
    }
}