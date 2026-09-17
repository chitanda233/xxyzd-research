package com.kwad.sdk.components;

/* JADX INFO: loaded from: classes3.dex */
public final class g {
    public static boolean encryptDisable() {
        return dN("KEY_HOST_ENCRYPT_DISABLE");
    }

    public static boolean dN(String str) {
        DevelopMangerComponents.DevelopValue developValueDM = d.dM(str);
        return developValueDM != null && ((Boolean) developValueDM.getValue()).booleanValue();
    }
}
