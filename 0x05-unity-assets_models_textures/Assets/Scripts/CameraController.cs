using UnityEngine;
public class CameraController : MonoBehaviour
{
    public bool watchPlayer = true;
    private Vector3 camOffset;
    public Transform playerTrans;
    public float smooth = 1f;
    // Start is called before the first frame update
    void Start()
    {
        camOffset = transform.position - playerTrans.position;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = playerTrans.position + camOffset;
        transform.position = Vector3.Slerp(playerTrans.position, newPosition, smooth);
        if (watchPlayer)
            playerTrans.LookAt(playerTrans);
    }
}
