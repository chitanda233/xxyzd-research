package com.kwad.components.offline.d;

import com.kwad.components.offline.api.obiwan.IObiwanLogcat;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements com.kwad.sdk.core.d.a.a {
    private final IObiwanLogcat axU;

    public c(IObiwanLogcat iObiwanLogcat) {
        this.axU = iObiwanLogcat;
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void v(String str, String str2) {
        this.axU.v(str, str2);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void v(String str, String str2, boolean z) {
        this.axU.v(str, str2, true);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void d(String str, String str2) {
        this.axU.d(str, str2);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void i(String str, String str2) {
        this.axU.i(str, str2);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void w(String str, String str2) {
        this.axU.w(str, str2);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void w(String str, String str2, boolean z) {
        this.axU.w(str, str2, z);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void e(String str, String str2) {
        this.axU.e(str, str2);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void printStackTraceOnly(Throwable th) {
        this.axU.printStackTraceOnly(th);
    }
}
