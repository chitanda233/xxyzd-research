package com.kwad.components.offline.e;

import android.content.Context;
import android.os.SystemClock;
import com.kwad.components.core.request.h;
import com.kwad.components.offline.api.InitCallBack;
import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.components.offline.api.tk.ITkOfflineCompo;
import com.kwad.components.offline.api.tk.TkLoggerReporter;
import com.kwad.components.offline.api.tk.model.report.TKDownloadMsg;
import com.kwad.library.solder.lib.i;
import com.kwad.sdk.core.response.model.SdkConfigData;
import com.kwad.sdk.o;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.core.offline.b.a<ITkOfflineCompo> {
    private static long axX;
    private final List<com.kwad.components.core.offline.a.f.a> axW;
    private final AtomicBoolean axY;

    @Override // com.kwad.components.core.offline.b.a
    public final String getTag() {
        return "TkInitModule";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tK() {
        return "TK";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tL() {
        return ITkOfflineCompo.PACKAGE_NAME;
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tM() {
        return "4.11.20.2";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tN() {
        return "https://p2-lm.adkwai.com/udata/pkg/KS-Android-KSAdSDk/offline_components/tk/ks_so-tachikomaNoSoRelease-4.11.20.2-62a6198d22-259.zip";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tO() {
        return "9574c2393e8bc4b0ca9b9c777d6919d9";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tP() {
        return "ks_tk_411202";
    }

    @Override // com.kwad.components.core.offline.b.a
    public final String tQ() {
        return ITkOfflineCompo.IMPL;
    }

    /* synthetic */ c(byte b) {
        this();
    }

    static final class a {
        private static final c ayi = new c(0);
    }

    public static c AF() {
        return a.ayi;
    }

    private c() {
        this.axW = new CopyOnWriteArrayList();
        this.axY = new AtomicBoolean(false);
    }

    public static void aU(Context context) {
        axX = SystemClock.elapsedRealtime();
        AF().init(context);
    }

    @Override // com.kwad.components.core.offline.b.a
    public final boolean isEnabled() {
        return com.kwad.sdk.core.h.a.OH();
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.components.core.offline.b.a
    public void a(Context context, boolean z, ITkOfflineCompo iTkOfflineCompo) {
        iTkOfflineCompo.init(context, new d(), new AnonymousClass1(iTkOfflineCompo, z, SystemClock.elapsedRealtime(), SystemClock.elapsedRealtime() - axX, context));
    }

    /* JADX INFO: renamed from: com.kwad.components.offline.e.c$1, reason: invalid class name */
    final class AnonymousClass1 implements InitCallBack {
        final /* synthetic */ ITkOfflineCompo axZ;
        final /* synthetic */ boolean aya;
        final /* synthetic */ long ayb;
        final /* synthetic */ long ayc;
        final /* synthetic */ Context dD;

        AnonymousClass1(ITkOfflineCompo iTkOfflineCompo, boolean z, long j, long j2, Context context) {
            this.axZ = iTkOfflineCompo;
            this.aya = z;
            this.ayb = j;
            this.ayc = j2;
            this.dD = context;
        }

        @Override // com.kwad.components.offline.api.InitCallBack
        public final void onSuccess(boolean z) {
            try {
                final b bVar = new b(this.axZ);
                com.kwad.sdk.components.d.a(com.kwad.components.core.offline.a.f.c.class, bVar);
                c.this.axY.set(true);
                int i = z ? 2 : 1;
                int i2 = this.aya ? 2 : 1;
                c.this.b(i, i2, SystemClock.elapsedRealtime() - this.ayb, this.ayc);
                TkLoggerReporter.get().reportTKSOLoad(ILoggerReporter.Category.APM_LOG, new TKDownloadMsg().setDownloadState(3).setOfflineLoadTime(this.ayc).setSoLoadTime(SystemClock.elapsedRealtime() - this.ayb).setInitSdkTimeConsuming(SystemClock.elapsedRealtime() - o.GE().Hi()).setThreadPoolCoreSize(i.Ec().DW().Ex()).setOfflineSource(i2).setSoSource(i).toJson());
                c.this.tJ();
                h.b(new com.kwad.components.core.request.i() { // from class: com.kwad.components.offline.e.c.1.1
                    @Override // com.kwad.components.core.request.i, com.kwad.components.core.request.h.a
                    public final void d(final SdkConfigData sdkConfigData) {
                        super.d(sdkConfigData);
                        com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.components.offline.e.c.1.1.1
                            @Override // com.kwad.sdk.utils.bi
                            public final void doTask() {
                                bVar.onConfigRefresh(AnonymousClass1.this.dD, sdkConfigData.toJson());
                            }
                        });
                    }
                });
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }

        @Override // com.kwad.components.offline.api.InitCallBack
        public final void onError(int i) {
            c.this.bg(i);
        }
    }

    public final void a(com.kwad.components.core.offline.a.f.a aVar) {
        if (aVar == null) {
            return;
        }
        try {
            if (this.axY.get()) {
                aVar.a(1, 1, 0L, 0L);
            }
            this.axW.add(aVar);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public final void b(com.kwad.components.core.offline.a.f.a aVar) {
        if (aVar == null) {
            return;
        }
        this.axW.remove(aVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(int i, int i2, long j, long j2) {
        Iterator<com.kwad.components.core.offline.a.f.a> it = this.axW.iterator();
        while (it.hasNext()) {
            try {
                it.next().a(i, i2, j, j2);
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }
    }
}
