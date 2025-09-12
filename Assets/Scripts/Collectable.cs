using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int value;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Math Symbols: + - * /   % (Modulus)

        collision.GetComponent<Score>().score += value;

        Debug.Log("Score: " + collision.GetComponent<Score>().score);
        Destroy(gameObject);
    }
}
