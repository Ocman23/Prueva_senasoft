using UnityEngine;

public class JailController : MonoBehaviour
{
    [SerializeField]private Rigidbody rb;
    public bool capture;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Capture()
    {
        if (capture == true) 
        {
            rb.useGravity = true;
        }
    }
}
