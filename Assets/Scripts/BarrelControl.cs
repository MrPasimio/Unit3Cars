using UnityEngine;

public class BarrelControl : MonoBehaviour
{
    public Transform spawnPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.position = spawnPoint.position;
    }
}
