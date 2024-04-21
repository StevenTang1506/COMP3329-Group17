using UnityEngine;

public class WinterCoin : MonoBehaviour
{
    public AudioClip coinSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Make sure your player GameObject has the tag "Player"
        {
            // Optionally, play a sound or animation
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            // CoinManager.Instance.AddCoins(1); // Add 1 coin to the total count
            Destroy(gameObject); // Destroy the coin object
        }
    }
}