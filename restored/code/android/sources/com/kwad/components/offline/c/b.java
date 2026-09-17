package com.kwad.components.offline.c;

import android.content.Context;
import android.os.Build;
import com.kwad.components.offline.api.IOfflineCompo;
import com.kwad.components.offline.api.InitCallBack;
import com.kwad.components.offline.api.adWaynePlayer.IAdWaynePlayerOfflineCompo;
import com.kwad.sdk.components.d;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.core.offline.b.a<IAdWaynePlayerOfflineCompo> {
    @Override // com.kwad.components.core.offline.b.a
    public final String getTag() {
        return "AdWaynePlayerInitModule";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tK() {
        return "WAYNEPLAYER";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tL() {
        return IAdWaynePlayerOfflineCompo.PACKAGE_NAME;
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tM() {
        return "4.4.20.1";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tN() {
        return "https://p5-lm.adkwai.com/udata/pkg/KS-Android-KSAdSDk/offline_components/adWaynePlayer/ks_so-adWaynePlayerNoSoRelease-4.4.20.1-f5fa94106c-87.zip";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tO() {
        return "de8902ac8ffc6225035515217d960ba1";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tP() {
        return "ks_wayne_player_44201";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tQ() {
        return IAdWaynePlayerOfflineCompo.IMPL;
    }

    /* synthetic */ b(byte b) {
        this();
    }

    @Override // com.kwad.components.core.offline.b.a
    public final /* bridge */ /* synthetic */ void a(Context context, boolean z, IOfflineCompo iOfflineCompo) {
        a(context, (IAdWaynePlayerOfflineCompo) iOfflineCompo);
    }

    static final class a {
        private static final b axA = new b(0);
    }

    private static b AB() {
        return a.axA;
    }

    private b() {
    }

    public static void aU(Context context) {
        AB().init(context);
    }

    private void a(Context context, final IAdWaynePlayerOfflineCompo iAdWaynePlayerOfflineCompo) {
        iAdWaynePlayerOfflineCompo.init(context, new c(), new InitCallBack() { // from class: com.kwad.components.offline.c.b.1
            @Override // com.kwad.components.offline.api.InitCallBack
            public final void onSuccess(boolean z) {
                try {
                    d.a(com.kwad.components.core.offline.a.b.a.class, new com.kwad.components.offline.c.a(iAdWaynePlayerOfflineCompo));
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

    @Override // com.kwad.components.core.offline.b.a
    public final boolean isEnabled() {
        return Build.VERSION.SDK_INT >= e.a(com.kwad.sdk.core.config.c.aQt) && ((Boolean) e.b(com.kwad.sdk.core.config.c.aQq)).booleanValue();
    }
}
