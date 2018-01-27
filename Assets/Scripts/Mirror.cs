using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

    public enum Color { White, Red, Green, Blue };
    const int MRot0 = 0, MRot90 = 90, MRot180 = 180, MRot270 = 270;

    public int mRotation = 270;
    public Color mColor = Color.White;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

	void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.CompareTag("LaserWhite") ||
			other.gameObject.CompareTag("LaserRed") ||
			other.gameObject.CompareTag("LaserGreen") ||
			other.gameObject.CompareTag("LaserBlue"))
		{
			
            
            

            if (mRotation == MRot0)
			{
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
            }
            else if (mRotation == MRot270)
			{
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
            }
			else if (mRotation == MRot180 || mRotation == MRot90)
			{
                Destroy(other.gameObject);
			}
			

		}
    }
}
