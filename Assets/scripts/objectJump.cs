using UnityEngine;

public class objectJump : MonoBehaviour
{
    private Rigidbody rb;

    public void Jump()
    {
        rb.AddForce(Vector2.up * 250f);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
