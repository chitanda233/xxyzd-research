package com.kwad.components.offline.e.a;

import com.kwad.components.offline.api.tk.jsbridge.IOfflineCompoCallBackFunction;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements com.kwad.sdk.core.webview.c.c {
    private final IOfflineCompoCallBackFunction ayk;

    public a(IOfflineCompoCallBackFunction iOfflineCompoCallBackFunction) {
        this.ayk = iOfflineCompoCallBackFunction;
    }

    @Override // com.kwad.sdk.core.webview.c.c
    public final void b(final com.kwad.sdk.core.b bVar) {
        if (com.kwad.sdk.core.config.e.JY()) {
            GlobalThreadPools.Or().submit(new Runnable() { // from class: com.kwad.components.offline.e.a.a.1
                @Override // java.lang.Runnable
                public final void run() {
                    final String string = new com.kwad.sdk.core.webview.c.f(bVar).toJson().toString();
                    by.runOnUiThread(new Runnable() { // from class: com.kwad.components.offline.e.a.a.1.1
                        @Override // java.lang.Runnable
                        public final void run() {
                            if (a.this.ayk != null) {
                                a.this.ayk.onSuccess(string);
                            }
                        }
                    });
                }
            });
            return;
        }
        String string = new com.kwad.sdk.core.webview.c.f(bVar).toJson().toString();
        IOfflineCompoCallBackFunction iOfflineCompoCallBackFunction = this.ayk;
        if (iOfflineCompoCallBackFunction != null) {
            iOfflineCompoCallBackFunction.onSuccess(string);
        }
    }

    @Override // com.kwad.sdk.core.webview.c.c
    public final void onError(int i, String str) {
        String string = new com.kwad.sdk.core.webview.c.e(i, str).toJson().toString();
        IOfflineCompoCallBackFunction iOfflineCompoCallBackFunction = this.ayk;
        if (iOfflineCompoCallBackFunction != null) {
            iOfflineCompoCallBackFunction.onError(string);
        }
    }
}
