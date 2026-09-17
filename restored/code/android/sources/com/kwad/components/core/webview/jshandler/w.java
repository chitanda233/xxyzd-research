package com.kwad.components.core.webview.jshandler;

import android.os.Vibrator;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class w implements com.kwad.sdk.core.webview.c.a {
    private Vibrator ho;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "startVibrate";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.ho = (Vibrator) ServiceProvider.getContext().getSystemService("vibrator");
        by.a(ServiceProvider.getContext(), this.ho);
        cVar.b(null);
    }
}
