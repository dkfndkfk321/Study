using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStat
{

    public float speed { set; get; }
    public int damage { set; get; }

    public BulletStat(float speed, int damage)
    {
        this.speed = speed;
        this.damage = damage;
    }

 
}
