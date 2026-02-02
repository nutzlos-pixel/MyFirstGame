using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 mainCameraOffset = new Vector3(0, 6, -10);
    void Start()
    {
        
    }


    void LateUpdate()
    {
        transform.position = player.transform.position + mainCameraOffset;
    }
}
