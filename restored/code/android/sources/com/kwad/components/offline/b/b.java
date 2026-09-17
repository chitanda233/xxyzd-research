package com.kwad.components.offline.b;

import android.content.Context;
import com.kwad.components.offline.api.IOfflineCompo;
import com.kwad.components.offline.api.InitCallBack;
import com.kwad.components.offline.api.adLive.IAdLiveOfflineCompo;
import com.kwad.sdk.components.d;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.core.offline.b.a<IAdLiveOfflineCompo> {
    @Override // com.kwad.components.core.offline.b.a
    public final String getTag() {
        return "AdLiveInitModule";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tK() {
        return "LIVE";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tL() {
        return IAdLiveOfflineCompo.PACKAGE_NAME;
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tM() {
        return "4.8.13";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tN() {
        return "https://p5-lm.adkwai.com/udata/pkg/KS-Android-KSAdSDk/offline_components/adLive/ks_so-adLiveNoSoRelease-4.8.13-9cf471c757-289.zip";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tO() {
        return "0fbf552d09e097f1684d4cea957d070e";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tP() {
        return "ks_live_4810";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tQ() {
        return IAdLiveOfflineCompo.IMPL;
    }

    /* synthetic */ b(byte b) {
        this();
    }

    @Override // com.kwad.components.core.offline.b.a
    public final /* bridge */ /* synthetic */ void a(Context context, boolean z, IOfflineCompo iOfflineCompo) {
        a(context, (IAdLiveOfflineCompo) iOfflineCompo);
    }

    static final class a {
        private static final b axs = new b(0);
    }

    private static b Az() {
        return a.axs;
    }

    private b() {
    }

    public static void aU(Context context) {
        Az().init(context);
    }

    @Override // com.kwad.components.core.offline.b.a
    public final boolean isEnabled() {
        return ((Boolean) e.b(com.kwad.sdk.core.config.c.aOq)).booleanValue();
    }

    private void a(Context context, final IAdLiveOfflineCompo iAdLiveOfflineCompo) {
        iAdLiveOfflineCompo.init(context, new c(), new InitCallBack() { // from class: com.kwad.components.offline.b.b.1
            @Override // com.kwad.components.offline.api.InitCallBack
            public final void onSuccess(boolean z) {
                try {
                    d.a(com.kwad.components.core.offline.a.c.a.class, new com.kwad.components.offline.b.a(iAdLiveOfflineCompo));
                    b.this.tJ();
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }

            @Override // com.kwad.components.offline.api.InitCallBack
            public final void onError(int i) {
                b.this.bg(i);
            }
        });
    }
}
