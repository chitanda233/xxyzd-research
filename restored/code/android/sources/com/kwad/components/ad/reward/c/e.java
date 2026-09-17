package com.kwad.components.ad.reward.c;

import android.text.TextUtils;

/* JADX INFO: loaded from: classes3.dex */
public final class e implements com.kwad.sdk.core.webview.c.a {
    private String TAG;
    private com.kwad.sdk.core.webview.c.c qW;

    public static class a extends com.kwad.sdk.core.response.a.a {
        public String vc;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerExtraDialogListener";
    }

    public e() {
        String str = "ExtraDialogListener" + hashCode();
        this.TAG = str;
        com.kwad.sdk.core.d.c.d(str, "create: ");
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        com.kwad.sdk.core.d.c.d(this.TAG, "handleJsCall: " + cVar);
        this.qW = cVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        com.kwad.sdk.core.d.c.d(this.TAG, "onDestroy: ");
        this.qW = null;
    }

    public final void ik() {
        com.kwad.sdk.core.d.c.d(this.TAG, "notifyDialogClose: ");
        K("close");
    }

    private void K(String str) {
        if (TextUtils.isEmpty(str) || this.qW == null) {
            return;
        }
        a aVar = new a();
        aVar.vc = str;
        this.qW.b(aVar);
    }
}
