namespace MortiseFrame.Abacus.Extension {

    public static class Color32Extensions {

        public static MortiseFrame.Abacus.FColor32 ToColor(this UnityEngine.Color32 v) {
            return new MortiseFrame.Abacus.FColor32(v.r, v.g, v.b, v.a);
        }

    }

}