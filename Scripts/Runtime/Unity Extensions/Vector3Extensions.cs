using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LX.UnityExtensions
{
    public static class Vector3Extensions
    {
        public static Vector3 Planar(this Vector3 v) { return new Vector3(v.x, 0, v.z); }

        public static Vector2 XY(this Vector3 v) { return new Vector2(v.x, v.y); }
        public static Vector2 YZ(this Vector3 v) { return new Vector2(v.y, v.z); }
        public static Vector2 XZ(this Vector3 v) { return new Vector2(v.x, v.z); }
    }
}