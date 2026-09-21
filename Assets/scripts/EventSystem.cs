 using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public int score {  get; private set; }
    public int jump { get; private set; }
    

    public void IncrementScore()
    {
        score++;
    }
    public void Jump()
    {
        
    }
}
