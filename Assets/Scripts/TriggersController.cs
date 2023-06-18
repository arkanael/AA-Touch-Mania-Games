using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Triggers : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onEnter;

 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Rotator":
                onEnter.Invoke();
                break;
            case "Pin":
                onEnter.Invoke();
                break;
            default:
                break;
        }
    }
}
