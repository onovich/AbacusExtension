namespace MortiseFrame.Abacus.Extension {

    public static class FColorExtensions {

        public static UnityEngine.Color ToColor(this MortiseFrame.Abacus.FColor v) {
            return new UnityEngine.Color(v.r, v.g, v.b, v.a);
        }

    }

}