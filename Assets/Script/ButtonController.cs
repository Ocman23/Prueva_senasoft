using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
    [SerializeField] UnityEvent onTriggerEnter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            onTriggerEnter.Invoke();
        }
    }
}
