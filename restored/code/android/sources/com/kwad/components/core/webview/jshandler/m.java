package com.kwad.components.core.webview.jshandler;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.core.response.model.AdTemplate;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class m implements com.kwad.sdk.core.webview.c.a {
    private com.kwad.components.core.e.d.d QK;
    private KsAppDownloadListener apj;
    private AdTemplate mAdTemplate;
    private Context mContext;
    private com.kwad.sdk.core.webview.c.c qW;

    public static class a extends com.kwad.sdk.core.response.a.a {
        public String apJ;
        public String packageName;
    }

    public static class b extends com.kwad.sdk.core.response.a.a {
        public int apK;
        public int progress;
        public long soFarBytes;
        public int status;
        public long totalBytes;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "installAppForDownload";
    }

    public m(Context context, AdTemplate adTemplate) {
        this.mContext = context;
        this.mAdTemplate = adTemplate;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.qW = cVar;
        a aVar = new a();
        try {
            aVar.parseJson(new JSONObject(str));
            if (r(aVar.apJ, aVar.packageName)) {
                cVar.onError(-1, "param is empty");
                return;
            }
            if (this.QK == null) {
                q(aVar.apJ, aVar.packageName);
            }
            com.kwad.components.core.e.d.a.C0428a c0428aAv = new com.kwad.components.core.e.d.a.C0428a(this.mContext).as(true).at(false).aF(this.mAdTemplate).av(false);
            if (this.QK.w(c0428aAv)) {
                return;
            }
            this.QK.d(this.apj);
            this.QK.v(c0428aAv);
        } catch (Exception unused) {
            cVar.onError(-1, "data parse error");
        }
    }

    private static boolean r(String str, String str2) {
        return TextUtils.isEmpty(str) || TextUtils.isEmpty(str2);
    }

    private synchronized void q(String str, String str2) {
        this.QK = new com.kwad.components.core.e.d.d(this.mAdTemplate, null, str, str2);
        if (this.apj == null) {
            KsAppDownloadListener ksAppDownloadListenerYD = yD();
            this.apj = ksAppDownloadListenerYD;
            this.QK.b(ksAppDownloadListenerYD);
        }
    }

    private KsAppDownloadListener yD() {
        return new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.core.webview.jshandler.m.1
            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onIdle() {
                m.this.s(0, 0);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onProgressUpdate(int i) {
                if (i == 0) {
                    m.this.s(1, 0);
                } else {
                    m.this.s(2, i);
                }
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFinished() {
                m.this.s(8, 100);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFailed() {
                m.this.s(0, 0);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onInstalled() {
                m.this.s(12, 100);
            }

            @Override // com.kwad.sdk.core.download.a.a
            public final void onPaused(int i) {
                m.this.s(4, i);
            }
        };
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void s(int i, int i2) {
        if (this.qW != null) {
            b bVar = new b();
            bVar.status = i;
            bVar.progress = i2;
            AdTemplate adTemplate = this.mAdTemplate;
            if (adTemplate != null) {
                bVar.totalBytes = com.kwad.sdk.core.response.helper.e.eM(adTemplate).totalBytes;
                bVar.soFarBytes = com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate).soFarBytes;
                if (bVar.totalBytes > 0) {
                    bVar.apK = (int) ((bVar.soFarBytes * 100.0f) / bVar.totalBytes);
                } else {
                    bVar.apK = 0;
                }
            }
            this.qW.b(bVar);
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.qW = null;
    }
}
