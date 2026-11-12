using UnityEngine;

public class Coin : MonoBehaviour
{
    // Both are filled in by the CoinSpawner right after Instantiate:
    // a prefab cannot hold a reference to an object that lives in the scene.
    public int value;
    public GameManager gameManager;

    // Destroy() only takes effect at the end of the frame, so a second trigger callback
    // can still arrive in the same physics step. This guard makes the coin count only once.
    private bool collected;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collected)
        {
            return;
        }

        // A coin disappears only when the Player touches it (not the enemy, not other coins).
        if (other.CompareTag("Player"))
        {
            collected = true;
            gameManager.CoinCollected(value);
            Destroy(gameObject);
        }
    }
}
