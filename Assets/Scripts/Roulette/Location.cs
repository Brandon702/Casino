using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public enum eColors
{
    Red,
    Black,
    Green
}
public class Location
{
    public int val;
    public bool even;
    public eColors _color;

    public Location(int val, eColors color, bool even)
    {
        this.val = val;
        this.even = even;
        this._color = color;
    }
}
