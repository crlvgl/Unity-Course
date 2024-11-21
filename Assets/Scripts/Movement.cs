using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D body;
    public float speed = 10.0f;
    private bool jump = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        if (jump)
        {
            body.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
            jump = false;
        }
    }
}
