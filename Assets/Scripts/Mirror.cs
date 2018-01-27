using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

    public enum Color { White, Red, Green, Blue };
    public enum MirrorRot { Rot0, Rot90, Rot180, Rot270 };

    public MirrorRot mRotation = MirrorRot.Rot0;
    public Color mColor = Color.White;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void onTriggerEnter(Collider other)
    {
		if (other.gameObject.CompareTag("LaserWhite") ||
			other.gameObject.CompareTag("LaserRed") ||
			other.gameObject.CompareTag("LaserGreen") ||
			other.gameObject.CompareTag("LaserBlue"))
		{

			if (mRotation == MirrorRot.Rot0)
			{

			}
			else if (mRotation == MirrorRot.Rot90)
			{

			}
			else if (mRotation == MirrorRot.Rot180)
			{

			}
			else if (mRotation == MirrorRot.Rot270)
			{

			}

		}
    }
}
