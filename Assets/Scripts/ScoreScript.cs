using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
