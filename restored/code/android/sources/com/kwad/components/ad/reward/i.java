package com.kwad.components.ad.reward;

import com.kwad.sdk.core.response.model.AdTemplate;
import java.util.List;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
public final class i {
    private Map<String, List<AdTemplate>> tP;

    /* synthetic */ i(byte b) {
        this();
    }

    private i() {
        this.tP = new ConcurrentHashMap();
    }

    static class a {
        private static final i tQ = new i(0);
    }

    public static i hC() {
        return a.tQ;
    }

    public final void G(String str) {
        this.tP.remove(str);
    }
}
