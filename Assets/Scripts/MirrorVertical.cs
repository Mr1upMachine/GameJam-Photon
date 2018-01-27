using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorVertical : Mirror {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, NW) ||
            other.gameObject.transform.rotation == Quaternion.Euler(0, 0, NW2)) //if laser is travelling north
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 0) || transform.rotation == Quaternion.Euler(0, 0, 360) || transform.rotation == Quaternion.Euler(0, 0, -360))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, NE);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, -90) || transform.rotation == Quaternion.Euler(0, 0, 270))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, SW);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, SW) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, SW2)) //if laser is travelling west
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 0) || transform.rotation == Quaternion.Euler(0, 0, 360))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, SE);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, -90) || transform.rotation == Quaternion.Euler(0, 0, 270))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, NW);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, SE) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, SE2)) //if laser is travelling east
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 0) || transform.rotation == Quaternion.Euler(0, 0, 360))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, SW);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, -90) || transform.rotation == Quaternion.Euler(0, 0, 270))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, NE);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, NE) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, NE2)) //if laser is travelling south
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 0) || transform.rotation == Quaternion.Euler(0, 0, 360))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, SE);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, -90) || transform.rotation == Quaternion.Euler(0, 0, 270))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, NW);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        else if (IsVert(other)) //approaches flat edge, reverse
        {
            other.gameObject.transform.Rotate(0, 0, 180);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }

    protected bool IsVert(Collider2D other)
    {
        if (((other.gameObject.transform.rotation == Quaternion.Euler(0, 0, N) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, N2) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, N3)) && //N
                 transform.rotation == Quaternion.Euler(0, 0, 0))
            ||
            ((other.gameObject.transform.rotation == Quaternion.Euler(0, 0, W) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, W2)) && //W
                 transform.rotation == Quaternion.Euler(0, 0, 90))
            ||
            ((other.gameObject.transform.rotation == Quaternion.Euler(0, 0, S) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, S2)) && //S
                 transform.rotation == Quaternion.Euler(0, 0, 180))
            ||
            ((other.gameObject.transform.rotation == Quaternion.Euler(0, 0, E) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, E2)) && //E
                 transform.rotation == Quaternion.Euler(0, 0, 270)))
        {
            return true;
        }

        return false;

    }

}
