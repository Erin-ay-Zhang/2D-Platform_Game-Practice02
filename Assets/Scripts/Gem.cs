using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class Gem : MonoBehaviour,IItem
{
    public static event Action<int> OnGemCollect;
    public int worth = 5;

    public void Collect()
    {
        OnGemCollect.Invoke(worth);
        Destroy(gameObject);
    }
}
