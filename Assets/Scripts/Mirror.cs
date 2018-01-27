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

<<<<<<< HEAD
	void OnTriggerEnter2D(Collider2D other)
=======
    void onTriggerEnter(Collider2D mirrorBase)
>>>>>>> a7e391b79a5bbf17d86380ad89806861b8b22bf6
    {
        Destroy(mirrorBase.gameObject);


        if (mirrorBase.gameObject.CompareTag("LaserWhite") ||
			mirrorBase.gameObject.CompareTag("LaserRed") ||
			mirrorBase.gameObject.CompareTag("LaserGreen") ||
			mirrorBase.gameObject.CompareTag("LaserBlue"))
		{
			other.gameObject.transform.rotation = Quaternion.Euler (0, 0, 270);

            

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
