using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private Rigidbody rb;
    [SerializeField] float speed = 5f;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float moveZ = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward*moveZ*speed*Time.deltaTime);
        transform.Rotate(Vector3.up*moveX*speed*Time.deltaTime);
    }

    


}
