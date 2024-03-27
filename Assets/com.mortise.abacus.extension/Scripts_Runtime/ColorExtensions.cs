namespace MortiseFrame.Abacus.Extension {

    public static class ColorExtensions {

        public static MortiseFrame.Abacus.FColor ToColor(this UnityEngine.Color v) {
            return new MortiseFrame.Abacus.FColor(v.r, v.g, v.b, v.a);
        }

    }

}