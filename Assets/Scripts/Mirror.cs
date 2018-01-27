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

    void OnTriggerEnter2D(Collider2D mirrorBase)
    {

        if (mirrorBase.gameObject.CompareTag("LaserWhite") ||
			mirrorBase.gameObject.CompareTag("LaserRed") ||
			mirrorBase.gameObject.CompareTag("LaserGreen") ||
			mirrorBase.gameObject.CompareTag("LaserBlue"))
		{
            Destroy(mirrorBase.gameObject);


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
