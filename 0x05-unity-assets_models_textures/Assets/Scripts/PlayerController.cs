using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 6f;


    public void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direc = new Vector3(horizontal, 0f, vertical);

        if (direc.magnitude >= 0.1f)
        {
            controller.Move(direc * speed * Time.deltaTime);
        }
    }
}
