using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public float sensitivity = 600f;
    public Transform Body;
    private float xRotation = 150f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        Body.Rotate(Vector3.up * MouseX);
    }
}
