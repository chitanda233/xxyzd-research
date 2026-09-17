package com.kwad.sdk.utils;

import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class o {
    public static long boJ = -1;

    public static void fn(AdTemplate adTemplate) {
        if (adTemplate != null) {
            adTemplate.mVisibleTimeParam = boJ;
            adTemplate.mOutClickTimeParam = boJ;
        }
    }

    public static void fo(AdTemplate adTemplate) {
        if (adTemplate != null) {
            adTemplate.mOutClickTimeParam = System.currentTimeMillis();
        }
    }

    public static void fp(AdTemplate adTemplate) {
        if (adTemplate != null) {
            adTemplate.mVisibleTimeParam = System.currentTimeMillis();
        }
    }

    public static long fq(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return System.currentTimeMillis();
        }
        return adTemplate.mOutClickTimeParam > 0 ? adTemplate.mOutClickTimeParam : adTemplate.mVisibleTimeParam;
    }
}
