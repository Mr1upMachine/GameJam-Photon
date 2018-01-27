using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

    const int N = 0, N2 = 360, N3 = -360,
              NW = 45, NW2 = -315,
              W = 90, W2 = -270,  //Use with laser direction
              SW = 135, SW2 = -225,
              S = 180, S2 = -180,
              SE = 225, SE2 = -135,
              E = 270, E2 = -90,
              NE = 315, NE2 = -45;

    public bool canRotate = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, N) ||
            other.gameObject.transform.rotation == Quaternion.Euler(0, 0, N2) ||
            other.gameObject.transform.rotation == Quaternion.Euler(0, 0, N3)) //if laser is travelling north
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 0) || transform.rotation == Quaternion.Euler(0, 0, 360))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, E);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, 270) || transform.rotation == Quaternion.Euler(0, 0, -90))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, W);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, W) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, W)) //if laser is travelling west
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 90))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, N);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, 0) || transform.rotation == Quaternion.Euler(0, 0, 360))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, S);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, E) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, E2)) //if laser is travelling east
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 180))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, N);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, 270) || transform.rotation == Quaternion.Euler(0, 0, -90))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, S);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, S) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, S2)) //if laser is travelling south
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 90))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, E);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, 180))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, W);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        else if (IsDiag(other)) //approaches flat edge, reverse
        { 
            other.gameObject.transform.Rotate(0, 0, 180);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }

    private bool IsDiag(Collider2D other)
    {
        if ( ((other.gameObject.transform.rotation == Quaternion.Euler(0, 0, NW) || 
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, NW2)) && //NW
                 transform.rotation == Quaternion.Euler(0, 0, 0))
            ||
            ((other.gameObject.transform.rotation == Quaternion.Euler(0, 0, SW) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, SW2)) && //SW
                 transform.rotation == Quaternion.Euler(0, 0, 90))
            ||
            ((other.gameObject.transform.rotation == Quaternion.Euler(0, 0, SE) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, SE2)) && //SE
                 transform.rotation == Quaternion.Euler(0, 0, 180))
            ||
            ((other.gameObject.transform.rotation == Quaternion.Euler(0, 0, NE) ||
                 other.gameObject.transform.rotation == Quaternion.Euler(0, 0, NE2)) && //NE
                 transform.rotation == Quaternion.Euler(0, 0, 270)) )
        {
            return true;
        }

        return false;

    }

    private void OnMouseOver()
    {
        if (canRotate)
        {
            if (Input.GetMouseButtonDown(1))
            {
                if (transform.rotation == Quaternion.Euler(0, 0, 0))
                {
                    transform.rotation = Quaternion.Euler(0, 0, 270);
                }
                else if (transform.rotation == Quaternion.Euler(0, 0, 270))
                {
                    transform.rotation = Quaternion.Euler(0, 0, 180);
                }
                else if (transform.rotation == Quaternion.Euler(0, 0, 180))
                {
                    transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else if (transform.rotation == Quaternion.Euler(0, 0, 90))
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }
    }
}
