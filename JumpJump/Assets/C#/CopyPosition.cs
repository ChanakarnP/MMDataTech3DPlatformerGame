using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    Transform tranTarget;
    void Update()
    {
        transform.position = tranTarget.position;
    }
}
