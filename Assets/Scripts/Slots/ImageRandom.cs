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

    private void Update()
    {
        RandomImage();
    }

    private void RandomImage()
    {
        gameObject.GetComponent<Image>().sprite = sprites[UnityEngine.Random.Range(0, sprites.Length)];
    }

    private void EndRand()
    {
        enabled = false;
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