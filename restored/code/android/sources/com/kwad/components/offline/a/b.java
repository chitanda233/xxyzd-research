package com.kwad.components.offline.a;

import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import com.kwad.components.offline.api.IOfflineCompo;
import com.kwad.components.offline.api.InitCallBack;
import com.kwad.components.offline.api.adInnerEc.IAdInnerEcOfflineCompo;
import com.kwad.sdk.components.d;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.f;
import com.kwad.sdk.utils.bz;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.core.offline.b.a<IAdInnerEcOfflineCompo> {
    private static Handler jc;

    @Override // com.kwad.components.core.offline.b.a
    public final String getTag() {
        return "AdInnerEcInitModule";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tK() {
        return "INNEREC";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tL() {
        return IAdInnerEcOfflineCompo.PACKAGE_NAME;
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tM() {
        return "4.10.30.2";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tN() {
        return "https://p2-lm.adkwai.com/udata/pkg/KS-Android-KSAdSDk/offline_components/adInnerEc/ks_so-adInnerEcNoSoRelease-4.10.30.2-08303dddd3-280.zip";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tO() {
        return "0984ab7e4173f1240f90ed23696757e9";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tP() {
        return "ks_adinnerec_410302";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tQ() {
        return IAdInnerEcOfflineCompo.IMPL;
    }

    @Override // com.kwad.components.core.offline.b.a
    public final /* bridge */ /* synthetic */ void a(Context context, boolean z, IOfflineCompo iOfflineCompo) {
        a(context, (IAdInnerEcOfflineCompo) iOfflineCompo);
    }

    static final class a {
        private static final b awO = new b();
    }

    private static b Av() {
        return a.awO;
    }

    public static void aU(Context context) {
        Av().init(context);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void a(com.kwad.components.core.offline.a.a.a aVar) {
        com.kwad.sdk.core.d.c.d("AdInnerEcInitModule", ": setHostProvider 执行：");
        if (ServiceProvider.Um() != null) {
            aVar.tE();
        }
    }

    private void a(Context context, final IAdInnerEcOfflineCompo iAdInnerEcOfflineCompo) {
        iAdInnerEcOfflineCompo.init(context, new c(), new InitCallBack() { // from class: com.kwad.components.offline.a.b.1
            @Override // com.kwad.components.offline.api.InitCallBack
            public final void onSuccess(boolean z) {
                try {
                    com.kwad.sdk.core.d.c.d("AdInnerEcInitModule", "onOfflineCompoLoaded: 电商内循环离线组件初始化成功");
                    final com.kwad.components.offline.a.a aVar = new com.kwad.components.offline.a.a(iAdInnerEcOfflineCompo);
                    d.a(com.kwad.components.core.offline.a.a.a.class, aVar);
                    b.this.tJ();
                    if (b.jc == null) {
                        Handler unused = b.jc = new Handler(Looper.getMainLooper());
                    }
                    b.jc.postDelayed(new Runnable() { // from class: com.kwad.components.offline.a.b.1.1
                        @Override // java.lang.Runnable
                        public final void run() {
                            b bVar = b.this;
                            b.a(aVar);
                        }
                    }, com.alipay.sdk.m.y.c.f378a);
                    com.kwad.sdk.core.d.c.d("AdInnerEcInitModule", "onOfflineCompoLoaded: 电商内循环离线组件 注册 完成：");
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.d("AdInnerEcInitModule", "onOfflineCompoLoaded: 电商内循环离线组件 异常：" + th.getMessage());
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
        return ((Boolean) e.b(com.kwad.sdk.core.config.c.aQv)).booleanValue() && bz.aD(((f) ServiceProvider.get(f.class)).getApiVersion(), (String) e.b(com.kwad.sdk.core.config.c.aQA));
    }
}
