package com.kwad.sdk.core.network;

import android.text.TextUtils;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
public class q {
    private static volatile q aTZ;
    private final Map<String, String> aSG = new ConcurrentHashMap();

    private q() {
    }

    public static q Mu() {
        if (aTZ == null) {
            synchronized (q.class) {
                if (aTZ == null) {
                    aTZ = new q();
                }
            }
        }
        return aTZ;
    }

    public final void W(String str, String str2) {
        if (TextUtils.isEmpty(str) || TextUtils.isEmpty(str2)) {
            return;
        }
        this.aSG.put(str, str2);
    }

    public final String eJ(String str) {
        return this.aSG.get(str);
    }
}
