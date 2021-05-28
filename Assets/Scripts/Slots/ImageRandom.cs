using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ImageRandom : MonoBehaviour
{
    public Sprite[] sprites;
    public float stopTime;
    public int compareSprites = 0;

    public SController sController;

    private void Update()
    {
        RandomImage();
    }

    private void RandomImage()
    {
        int rng = UnityEngine.Random.Range(0, sprites.Length);
        compareSprites = rng;
        gameObject.GetComponent<Image>().sprite = sprites[rng];
    }

    private void EndRand()
    {
        enabled = false;
        sController.RoundOver();
    }

    public void StopRand()
    {
        Invoke("EndRand", stopTime);
    }

    public void StartRand()
    {
        enabled = true;
    }
}