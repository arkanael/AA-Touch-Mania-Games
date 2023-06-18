using UnityEngine;

public class PinController : MonoBehaviour
{
    private bool isPinned = false;

    private float speed;
    public Rigidbody2D pin;

    private void Start()
    {
        pin = GetComponent<Rigidbody2D>();
        speed = GameManager.instance.speedPin;
    }

    void Update()
    {
        if (!isPinned)
            pin.MovePosition(pin.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Rotator"))
        {
            transform.SetParent(collider.transform);
            

            if(collider.GetComponent<RotatorController>().speed > 0)
            {
                speed += 0.5f;
                collider.GetComponent<RotatorController>().speed += speed * Time.deltaTime;
                collider.GetComponent<RotatorController>().speed *= -1;
            }
            else
            {
                speed += -0.5f;
                collider.GetComponent<RotatorController>().speed += -speed * Time.deltaTime;
                collider.GetComponent<RotatorController>().speed *= -1;

            }

            ScoreController.PinCount++;
            isPinned = true;
        }
        else if (collider.CompareTag("Pin"))
        {
            GameManager.instance.EndGame();
        }
    }
}
