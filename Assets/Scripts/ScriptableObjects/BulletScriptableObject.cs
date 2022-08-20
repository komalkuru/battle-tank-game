﻿using UnityEngine;

/// <summary>
/// This Class is used to create Bullet Scriptable Objects with all the required properties of Bullets.
/// </summary>

[CreateAssetMenu(fileName = "BulletScriptableObject", menuName = "ScriptableObjects/NewBulletScriptableObject")]
public class BulletScriptableObject : ScriptableObject
{
    public BulletType bulletType;
    public float speed;
    public int Damage;
}

