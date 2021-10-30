using System.Collections;
using UnityEngine;

public class SFXLibrary : MonoBehaviour
{
    public AudioSource bulletShot;
    public AudioSource bulletHit;
    public AudioSource waterGet;
    public AudioSource saltGet;
  


    public void playBulletShot()
    {
        bulletShot.PlayOneShot(bulletShot.clip);
    }

    public void playBulletHit()
    {
        bulletHit.PlayOneShot(bulletHit.clip);
    }
    public void playWaterGet()
    {
        waterGet.PlayOneShot(waterGet.clip);
    }
    public void playSaltGet()
    {
        saltGet.PlayOneShot(saltGet.clip);
    }
}
