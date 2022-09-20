using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public Vector3 ResetTranslationVector;

    public void ResetTranslation() {
        transform.position = ResetTranslationVector;
        transform.rotation = Quaternion.Euler(0,0,0);
    }
}
