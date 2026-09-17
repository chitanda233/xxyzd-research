package com.kwad.components.core.offline.a.f.a;

import com.kwad.sdk.core.response.model.AdResultData;
import java.lang.ref.WeakReference;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static final Map<Integer, WeakReference<AdResultData>> abw = new HashMap();

    public static void a(int i, AdResultData adResultData) {
        if (adResultData == null) {
            return;
        }
        abw.put(Integer.valueOf(i), new WeakReference<>(adResultData));
    }

    public static AdResultData bf(int i) {
        WeakReference<AdResultData> weakReference = abw.get(Integer.valueOf(i));
        if (weakReference == null || weakReference.get() == null) {
            return null;
        }
        return weakReference.get();
    }
}
