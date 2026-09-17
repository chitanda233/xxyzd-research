package com.kwad.components.core.innerEc.local;

import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.response.helper.b;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static final CancelInfo aaM = new CancelInfo();

    public static boolean be(int i) {
        c.d("LoginLocalCounter", "checkEnableInnerEc maxCount: " + i);
        return i <= 0 || aaM.getCancelCount() < i;
    }

    public static int getCancelCount() {
        return aaM.getCancelCount();
    }

    public static void f(AdTemplate adTemplate, String str) {
        c.d("LoginLocalCounter", "onAuthFail: " + str);
        aaM.checkAndAdd();
        aK(adTemplate);
    }

    public static void g(AdTemplate adTemplate, String str) {
        c.d("LoginLocalCounter", "onAuthCancel: " + str);
        aaM.checkAndAdd();
        aK(adTemplate);
    }

    public static void aO(String str) {
        c.d("LoginLocalCounter", "onAuthSuccess: " + str);
        aaM.reset();
    }

    private static void aK(AdTemplate adTemplate) {
        AdTemplate.isInnerEcCancelDowngrade = !be(b.ev(adTemplate));
    }
}
