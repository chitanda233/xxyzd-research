package com.kwad.sdk.core.d;

import android.util.Log;

/* JADX INFO: loaded from: classes3.dex */
final class b implements com.kwad.sdk.core.d.a.a {
    b() {
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void v(String str, String str2) {
        if (c.aSP && a.oV.booleanValue()) {
            Log.v(str, str2);
        }
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void v(String str, String str2, boolean z) {
        Log.v(str, str2);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void d(String str, String str2) {
        if (c.aSP && a.oV.booleanValue()) {
            Log.d(str, str2);
        }
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void i(String str, String str2) {
        if (c.aSP) {
            Log.i(str, str2);
        }
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void w(String str, String str2) {
        if (c.aSP) {
            Log.w(str, str2);
        }
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void w(String str, String str2, boolean z) {
        if (z) {
            Log.w(str, str2);
        }
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void e(String str, String str2) {
        if (c.aSP) {
            Log.e(str, str2);
        }
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void printStackTraceOnly(Throwable th) {
        if (c.aSP && a.oV.booleanValue() && th != null) {
            th.printStackTrace();
        }
    }
}
