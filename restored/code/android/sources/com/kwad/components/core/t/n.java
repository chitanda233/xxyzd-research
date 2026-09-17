package com.kwad.components.core.t;

import android.content.Context;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class n {
    public static boolean e(AdTemplate adTemplate, boolean z) {
        if (!z && com.kwad.sdk.core.response.helper.b.dQ(com.kwad.sdk.core.response.helper.e.eM(adTemplate))) {
            return com.kwad.sdk.core.config.e.KK();
        }
        return false;
    }

    public static void i(Context context, AdTemplate adTemplate) {
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(context).aq(true).aF(adTemplate));
    }
}
