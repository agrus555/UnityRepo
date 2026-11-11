using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W)){
            transform.position += (Vector3.forward * Time.deltaTime);
            }
        if (Input.GetKey(KeyCode.S)){
            transform.position += (Vector3.back * Time.deltaTime);
            }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += (Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += (Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down, 1f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 1f);
        }


    }
}
