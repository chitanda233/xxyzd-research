package com.kwad.components.core.e.b;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static c pB() {
        return C0425a.Qk;
    }

    public static String y(long j) {
        String strZ = pB().z(j);
        return strZ.endsWith("=") ? strZ.replace("=", "") : strZ;
    }

    public static long ak(String str) {
        return pB().al(str);
    }

    /* JADX INFO: renamed from: com.kwad.components.core.e.b.a$a, reason: collision with other inner class name */
    static class C0425a {
        private static final c Qk = c.a(new int[]{7, 8, 4, 2, 0, 3, 6, 9, 1, 8});
    }
}
