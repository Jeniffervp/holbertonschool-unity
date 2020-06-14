using UnityEngine;
public class CameraController : MonoBehaviour
{
    public bool rotAround = true;
    private Vector3 camOffset;
    public Transform playerTrans;
    public float smooth = 1f;
    public float rotationSpeed = 1f;

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
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);

            camOffset = camTurnAngle * camOffset;
        }

        Vector3 newPosition = playerTrans.position + camOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smooth);

        if (rotAround)
            transform.LookAt(playerTrans);
    }
}
