using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

    public enum Color { White, Red, Green, Blue };
    public enum Direction { N, NE, E, SE, S, SW, W, NW };
    public enum MirrorRot { Rot0, Rot90, Rot180, Rot270 };

    public MirrorRot mRotation = MirrorRot.Rot0;
    public Color mColor = Color.White;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
