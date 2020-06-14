using UnityEngine;
public class CameraController : MonoBehaviour
{
    public bool watchPlayer = false;
    public bool rotateAround = true;
    private Vector3 camOffset;
    public Transform playerTrans;
    public float smooth = 1f;
    public float rotationSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        camOffset = transform.position - playerTrans.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (rotateAround)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);

            camOffset = camTurnAngle * camOffset;
        }

        Vector3 newPosition = playerTrans.position + camOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smooth);

        if (watchPlayer || rotateAround)
            transform.LookAt(playerTrans);
    }
}
