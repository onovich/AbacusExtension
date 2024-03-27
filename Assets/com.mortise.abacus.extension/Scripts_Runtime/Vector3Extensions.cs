namespace MortiseFrame.Abacus.Extension {

    public static class Vector3Extensions {

        public static MortiseFrame.Abacus.FVector2 ToFVector2(this UnityEngine.Vector3 v) {
            return new MortiseFrame.Abacus.FVector2(v.x, v.y);
        }

        public static MortiseFrame.Abacus.FVector3 ToFVector3(this UnityEngine.Vector3 v) {
            return new MortiseFrame.Abacus.FVector3(v.x, v.y, v.z);
        }

    }

}