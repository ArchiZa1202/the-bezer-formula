using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b2 : MonoBehaviour
{
    static public Vector3 Bezier(float u, List<Vector3> pts, int iL = 0, int iR = -1)
    {
        if (iR == -1)
        { 
            iR = pts.Count - 1;
        }
        if (iL == iR)
        { // Терминальный случай 
            return (pts[iL]);
        }
        // Два рекурсивных вызова, в каждый передается 
        // уменьшенное на 1 количество точек
        Vector3 lV3 = Bezier(u, pts, iL, iR - 1); 
        Vector3 rV3 = Bezier(u, pts, iL + 1, iR);   
        
        Vector3 res = Vector3.LerpUnclamped(lV3, rV3, u); 
        return (res);
    }

}
