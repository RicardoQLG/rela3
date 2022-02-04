using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    public Vector3 position;
    public string name;
    public GameObject obj;

    public Tile(Vector3 position, string name, GameObject obj)
    {
        this.position = position;
        this.name = name;
        this.obj = obj;
    }
}