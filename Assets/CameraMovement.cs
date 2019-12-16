using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraDistance = new Vector3(10, 0, 0);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + cameraDistance;
    }
}
