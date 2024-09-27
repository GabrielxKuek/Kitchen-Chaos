
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class KitchenObjectSO : ScriptableObject
{
    public Transform prefab; // scriptable objects are read only data containers, not written on so its public. (following codemonkey naming convention)
    public Sprite sprite;
    public string objectName;
}
