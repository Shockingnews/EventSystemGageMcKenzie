using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{

    public UnityEvent coinCollect;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            coinCollect.Invoke();
            Destroy(gameObject);
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
