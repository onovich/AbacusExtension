namespace MortiseFrame.Abacus.Extension {

    public static class Vector2Extensions {

        public static MortiseFrame.Abacus.FVector2 ToFVector2(this UnityEngine.Vector2 v) {
            return new MortiseFrame.Abacus.FVector2(v.x, v.y);
        }

        public static MortiseFrame.Abacus.FVector3 ToFVector3(this UnityEngine.Vector2 v) {
            return new MortiseFrame.Abacus.FVector3(v.x, v.y, 0);
        }

    }

}