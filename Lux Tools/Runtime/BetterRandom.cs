using UnityEngine;

namespace LX.Random
{
    using Random = UnityEngine.Random;

    public struct BetterRandom
    {
        public static float Value => Random.value;
        public static float AbsValue => (Value - 0.5f) * 2f;

        public static Vector2 V2Value => new Vector2(Value, Value);
        public static Vector2 V2AbsValue => new Vector2(AbsValue, AbsValue);

        public static Vector2 V3Value => new Vector3(Value, Value, Value);
        public static Vector2 V3AbsValue => new Vector3(AbsValue, AbsValue, AbsValue);

        public static Quaternion RandomRotation => Quaternion.Euler(V3Value * 360f);
        public static Quaternion RandomYRotation => Quaternion.Euler(0, Value * 360f, 0);
    }
}