using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float leftLimit = -3.2f;
    public float rightLimit = 3.2f;
    public GameManager gameManager;

    void Update()
    {
        if (gameManager != null && gameManager.scoreText == null)
        {
            gameManager = GameManager.Instance;
        }

        float moveX = 0f;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchWorld = Camera.main.ScreenToWorldPoint(touch.position);
            touchWorld.z = 0;
            moveX = touchWorld.x - transform.position.x;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorld.z = 0;
            moveX = mouseWorld.x - transform.position.x;
        }

        Vector3 newPosition = transform.position;
        newPosition.x += moveX * Time.deltaTime * 10f;
        newPosition.x = Mathf.Clamp(newPosition.x, leftLimit, rightLimit);
        transform.position = newPosition;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            if (gameManager != null)
                gameManager.AddScore(1);
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Obstacle"))
        {
            if (gameManager != null)
                gameManager.GameOver();
        }
    }
}
