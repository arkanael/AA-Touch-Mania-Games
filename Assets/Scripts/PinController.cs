using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PinController : MonoBehaviour
{
    private bool isPinned;
    
    public float speedPin = 20f;

    public Rigidbody2D pin;
    // Start is called before the first frame update
    void Start()
    {
        pin = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isPinned)
        pin.MovePosition(pin.position + Vector2.up * speedPin * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Rotator")
        {
            transform.SetParent(collision.transform);
            isPinned = true;
        }
    }
}
