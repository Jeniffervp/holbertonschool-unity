using UnityEngine;
public class CameraController : MonoBehaviour
{
    public bool rotAround = true;
    private Vector3 camOffset;
    public Transform playerTrans;
    public float smooth = 1f;
    public float rotationSpeed = 1f;
    private Quaternion camTurnAngle;

    // Start is called before the first frame update
    void Start()
    {
        camOffset = transform.position - playerTrans.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (rotAround)
        {
            if (Input.GetMouseButton(1))
            {
                camTurnAngle = Quaternion.Euler(Input.GetAxis("Mouse Y") * rotationSpeed, Input.GetAxis("Mouse X") * rotationSpeed, 0);
            }
            camOffset = camTurnAngle * camOffset;
        }

        Vector3 newPosition = playerTrans.position + camOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smooth);

        if (rotAround)
            transform.LookAt(playerTrans);
    }
}
