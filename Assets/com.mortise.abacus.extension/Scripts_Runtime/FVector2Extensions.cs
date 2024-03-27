namespace MortiseFrame.Abacus.Extension {

    public static class FVector2Extensions {

        public static UnityEngine.Vector2 ToVector2(this MortiseFrame.Abacus.FVector2 v) {
            return new UnityEngine.Vector2(v.x, v.y);
        }

        public static UnityEngine.Vector3 ToVector3(this MortiseFrame.Abacus.FVector2 v) {
            return new UnityEngine.Vector3(v.x, v.y, 0);
        }

        public static MortiseFrame.Abacus.FVector3 ToFVector3(this UnityEngine.Vector2 v) {
            return new MortiseFrame.Abacus.FVector3(v.x, v.y, 0);
        }

    }

}