using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public float playerHealth = 3;
    public Text healthText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            playerHealth -= 1;
            healthText.text = playerHealth.ToString("0");
            collision.collider.GetComponent<MineExplosion>().Explode();
        }

        if (playerHealth == 0)
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}