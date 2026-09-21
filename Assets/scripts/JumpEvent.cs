using UnityEngine;
using UnityEngine.Events;

public class JumpEvent : MonoBehaviour
{
    public UnityEvent startJump;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            startJump.Invoke();
            
        }
    }

    public void TestMethod()
    {
        print("hello?");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
