using UnityEngine;
using TMPro;

public class UiController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    private EventSystem gameController;

    private void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<EventSystem>();
    }

    public void UpdateScore()
    {
        scoreText.text = gameController.score.ToString();
    }
}
