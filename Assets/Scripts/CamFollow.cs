using UnityEngine;

public class CamFollow : MonoBehaviour { 

    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPos = player.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = new Vector3(smoothedPos.x, smoothedPos.y, player.position.z + offset.z);
    }
}
