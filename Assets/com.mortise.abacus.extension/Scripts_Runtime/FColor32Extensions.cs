namespace MortiseFrame.Abacus.Extension {

    public static class FColor32Extensions {

        public static UnityEngine.Color32 ToColor(this MortiseFrame.Abacus.FColor32 v) {
            return new UnityEngine.Color32(v.r, v.g, v.b, v.a);
        }

    }

}