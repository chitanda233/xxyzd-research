package com.kwad.sdk.core.h;

import android.text.TextUtils;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.h;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.bt;
import com.kwad.sdk.utils.i;
import java.util.List;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static C0514a aYU;
    private static boolean aYV;
    private static final AtomicBoolean mHasInit = new AtomicBoolean(false);
    private static boolean aYW = true;

    /* JADX INFO: renamed from: com.kwad.sdk.core.h.a$a, reason: collision with other inner class name */
    public static class C0514a extends com.kwad.sdk.core.response.a.a {
        public List<String> aYX;
        public int aYY;
        public List<String> aYZ;
        public List<String> aZa;
    }

    public static void OE() {
        i.execute(new bi() { // from class: com.kwad.sdk.core.h.a.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (a.mHasInit.getAndSet(true)) {
                    return;
                }
                try {
                    C0514a unused = a.aYU = new C0514a();
                    boolean unused2 = a.aYV = ((h) ServiceProvider.get(h.class)).Gr();
                    String strGs = ((h) ServiceProvider.get(h.class)).Gs();
                    if (a.aYV && !TextUtils.isEmpty(strGs)) {
                        a.aYU.parseJson(new JSONObject(strGs));
                        a.OF();
                        return;
                    }
                    boolean unused3 = a.aYW = a.aYV;
                } catch (Throwable unused4) {
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void OF() {
        aYW = true;
        if (aYU == null) {
            return;
        }
        ey(OG());
        ai.l("ksadsdk_tk_switch", "tk_config", aYW);
    }

    private static void ey(int i) {
        for (int i2 = 0; i2 < Integer.toBinaryString(i).length(); i2++) {
            if (((1 << i2) & i) != 0) {
                aYW = false;
                ez(i2);
                if (aYW) {
                    return;
                }
            }
        }
    }

    private static void ez(int i) {
        if (i == 0) {
            if (aYU.aYZ.contains(bt.WW())) {
                return;
            }
            aYW = true;
        } else if (i == 1) {
            if (aYU.aYY < bt.Xg()) {
                aYW = true;
            }
        } else if (i == 2) {
            if (aYU.aYX.contains(BuildConfig.VERSION_NAME)) {
                return;
            }
            aYW = true;
        } else if (i == 3 && !aYU.aZa.contains(bt.WV())) {
            aYW = true;
        }
    }

    private static int OG() {
        int i = !aYU.aYZ.isEmpty() ? 1 : 0;
        int i2 = aYU.aYY != 0 ? 2 : 0;
        return ((i ^ i2) ^ (!aYU.aYX.isEmpty() ? 4 : 0)) ^ (aYU.aZa.isEmpty() ? 0 : 8);
    }

    public static boolean OH() {
        if (mHasInit.get()) {
            return aYW;
        }
        return ai.m("ksadsdk_tk_switch", "tk_config", true);
    }
}
