namespace MortiseFrame.Abacus.Extension {

    public static class FVector3Extensions {

        public static UnityEngine.Vector2 ToVector2(this MortiseFrame.Abacus.FVector3 v) {
            return new UnityEngine.Vector2(v.x, v.y);
        }

        public static UnityEngine.Vector3 ToVector3(this MortiseFrame.Abacus.FVector3 v) {
            return new UnityEngine.Vector3(v.x, v.y, v.z);
        }

        public static MortiseFrame.Abacus.FVector2 ToFVector2(this UnityEngine.Vector3 v) {
            return new MortiseFrame.Abacus.FVector2(v.x, v.y);
        }

    }

}