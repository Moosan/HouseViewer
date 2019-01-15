using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosChange : MonoBehaviour {
    [SerializeField]
    private Transform center;
	void Update () {
        transform.localPosition = center.localPosition;
	}
}
