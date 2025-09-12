using UnityEngine;

public class ConeController : MonoBehaviour
{
    //hurt sprite variable
    public Sprite hurtSprite;
    //Sound variable
    public AudioClip hurtSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().PlayOneShot(hurtSound);
        GetComponent<SpriteRenderer>().sprite = hurtSprite;
        Destroy(gameObject, 1);        
    }

}
