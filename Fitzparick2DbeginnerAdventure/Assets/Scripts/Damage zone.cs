using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagezone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        RubyController contoller = other.GetComponent<RubyController>();
        if (contoller != null)
        {
            contoller.ChangeHealth(-1);
        }
    }
}
