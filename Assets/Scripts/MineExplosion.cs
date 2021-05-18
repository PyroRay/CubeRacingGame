using UnityEngine;
using UnityEngine.Audio;
public class MineExplosion : MonoBehaviour
{
    public GameObject explosionEffect;

    public void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
