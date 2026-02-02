using UnityEngine;

public class FollowPlayerPOV : MonoBehaviour
{
    public GameObject player;
    private Vector3 povCameraOffset = new Vector3(0, 4.4f, 0.17f);
    void Start()
    {
        
    }
    void LateUpdate()
    {
        transform.position = player.transform.position + povCameraOffset;
    }
}
