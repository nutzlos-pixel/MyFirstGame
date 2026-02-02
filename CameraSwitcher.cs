using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;
    public Camera povCamera;
    KeyCode switchCamera = KeyCode.Tab;
    void Start()
    {
    }
    private void Update()
    {
        if(Input.GetKeyDown(switchCamera))
        {
            if(mainCamera.enabled)
            {
                mainCamera.enabled = false;
                povCamera.enabled = true;
            }
            else
            {
                mainCamera.enabled = true;
                povCamera.enabled = false;
            }
        }
    }
}
