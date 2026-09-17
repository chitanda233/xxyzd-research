package com.kwad.sdk.core.network.a;

import android.util.Log;
import com.kwad.sdk.export.proxy.AdHttpProxy;
import com.kwad.sdk.export.proxy.AdHttpResponseListener;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.h;
import java.io.OutputStream;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static AdHttpProxy aUa;

    /* JADX INFO: renamed from: com.kwad.sdk.core.network.a.a$a, reason: collision with other inner class name */
    public static class C0515a {
        public String msg;
    }

    private static boolean Mv() {
        h hVar = (h) ServiceProvider.get(h.class);
        if (hVar != null) {
            return hVar.Gh();
        }
        return false;
    }

    public static boolean a(String str, OutputStream outputStream, C0515a c0515a, long j, boolean z, AdHttpResponseListener adHttpResponseListener) {
        AdHttpProxy aVar;
        boolean zMv = Mv();
        AdHttpProxy adHttpProxy = aUa;
        if (adHttpProxy == null) {
            com.kwad.sdk.core.d.c.d("VideoCacheHelper", "isAdCacheEnable:" + zMv);
            if (zMv) {
                aVar = com.kwad.sdk.h.ES();
            } else {
                aVar = new com.kwad.sdk.core.network.c.a();
            }
            adHttpProxy = aVar;
            aUa = adHttpProxy;
        }
        AdHttpProxy adHttpProxy2 = adHttpProxy;
        if (com.kwad.framework.b.a.oV.booleanValue()) {
            if (adHttpProxy2 instanceof com.kwad.sdk.core.network.c.b) {
                com.kwad.sdk.core.d.c.d("VideoCacheHelper", "okHttp");
            } else {
                com.kwad.sdk.core.d.c.d("VideoCacheHelper", "Http");
            }
        }
        try {
            com.kwad.sdk.core.d.c.d("VideoCacheHelper", "downloadUrlToStream success size:" + j + " url:" + str);
            adHttpProxy2.downloadUrlToStream(str, outputStream, j, z, adHttpResponseListener);
            return true;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.d("VideoCacheHelper", Log.getStackTraceString(e));
            c0515a.msg = e.getMessage();
            return false;
        }
    }
}
