package com.kwad.sdk.commercial.g;

import android.content.Context;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.kuaishou.weapon.p0.t;
import com.kwad.sdk.core.c.b;
import com.kwad.sdk.core.c.d;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.i.g;
import com.kwad.sdk.i.h;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.f;
import com.kwad.sdk.utils.bf;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.i;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements com.kwad.sdk.core.d.a.a {
    private final AtomicBoolean mHasInit;

    @Override // com.kwad.sdk.core.d.a.a
    public final void printStackTraceOnly(Throwable th) {
    }

    /* synthetic */ a(byte b) {
        this();
    }

    private a() {
        this.mHasInit = new AtomicBoolean(false);
    }

    /* JADX INFO: renamed from: com.kwad.sdk.commercial.g.a$a, reason: collision with other inner class name */
    static final class C0499a {
        private static final a aKB = new a(0);
    }

    public static a IH() {
        return C0499a.aKB;
    }

    public static void register() {
        c.a(IH());
    }

    public final void dA(String str) {
        try {
            if (this.mHasInit.get()) {
                return;
            }
            Context contextUm = ServiceProvider.Um();
            final f fVar = (f) ServiceProvider.get(f.class);
            h.RZ().a(str, g.RU().gN(ServiceProvider.getSDKConfig().appId).gO(ServiceProvider.getSdkVersion()).gP(bf.getOaid()).gS(bf.dN(contextUm)).gQ(bf.getDeviceId()).gR(bf.dO(contextUm)).n(fVar.FO()).cd(com.kwad.sdk.components.g.encryptDisable()).gT(fVar.FN()).i(fVar.FQ()).o(fVar.FP()), new com.kwad.sdk.i.f() { // from class: com.kwad.sdk.commercial.g.a.1
                @Override // com.kwad.sdk.i.f
                public final String av(String str2) {
                    return fVar.av(str2);
                }

                @Override // com.kwad.sdk.i.f
                public final void a(String str2, Map<String, String> map, String str3) {
                    fVar.a(str2, map, str3);
                }
            });
            b.Mh();
            b.a(new d() { // from class: com.kwad.sdk.commercial.g.a.2
                @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
                public final void onBackToForeground() {
                    super.onBackToForeground();
                    i.schedule(new bi() { // from class: com.kwad.sdk.commercial.g.a.2.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            h.RZ().Sa();
                        }
                    }, 3L, TimeUnit.SECONDS);
                }

                @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
                public final void onBackToBackground() {
                    super.onBackToBackground();
                }
            });
            this.mHasInit.set(true);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void v(String str, String str2) {
        h.RZ().g(t.c, str, str2);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void v(String str, String str2, boolean z) {
        h.RZ().g(t.c, str, str2);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void d(String str, String str2) {
        h.RZ().g(t.t, str, str2);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void i(String str, String str2) {
        h.RZ().g(t.e, str, str2);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void w(String str, String str2) {
        h.RZ().g(IAdInterListener.AdReqParam.WIDTH, str, str2);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void w(String str, String str2, boolean z) {
        h.RZ().g(IAdInterListener.AdReqParam.WIDTH, str, str2);
    }

    @Override // com.kwad.sdk.core.d.a.a
    public final void e(String str, String str2) {
        h.RZ().g("e", str, str2);
    }
}
