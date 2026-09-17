package com.kwad.components.core.offline.b;

import android.content.Context;
import android.os.SystemClock;
import android.text.TextUtils;
import com.kwad.components.offline.api.IOfflineCompo;
import com.kwad.library.solder.lib.ext.PluginError;
import com.kwad.library.solder.lib.i;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a<T extends IOfflineCompo<?>> {
    private long Kc;
    private String abx = "";

    protected abstract void a(Context context, boolean z, T t);

    protected abstract String getTag();

    public abstract boolean isEnabled();

    public abstract String tK();

    protected abstract String tL();

    protected abstract String tM();

    protected abstract String tN();

    protected abstract String tO();

    protected abstract String tP();

    protected abstract String tQ();

    public final void init(Context context) {
        try {
            if (isEnabled()) {
                this.Kc = SystemClock.elapsedRealtime();
                com.kwad.components.core.offline.moitor.a.c(tK(), getDuration());
                c.d(getTag(), "init start");
                aA(context);
                return;
            }
            try {
                c.d(getTag(), "del start");
                com.kwad.library.solder.a.a.o(context, tL());
            } catch (Throwable unused) {
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public long getDuration() {
        return SystemClock.elapsedRealtime() - this.Kc;
    }

    private void aA(final Context context) {
        if (com.kwad.components.core.a.Os.booleanValue()) {
            c.d(getTag(), "init start disableOffline");
            a(context, false, getClass().getClassLoader());
        } else {
            com.kwad.library.solder.lib.c.b bVarTH = tH();
            c.d(getTag(), "load component start pluginInfo: " + bVarTH);
            com.kwad.library.solder.a.a.a(context, bVarTH, new com.kwad.library.solder.lib.ext.b.a() { // from class: com.kwad.components.core.offline.b.a.1
                long aby;

                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.library.solder.lib.ext.b.C0493b, com.kwad.library.solder.lib.ext.b
                public void a(com.kwad.library.solder.lib.b.a aVar, com.kwad.library.b.a aVar2) {
                    super.a(aVar, aVar2);
                    c.d(a.this.getTag(), "load component resource success");
                    com.kwad.components.core.offline.moitor.a.a(a.this.tK(), a.this.getDuration(), a.this.abx);
                    a aVar3 = a.this;
                    aVar3.a(context, !"LOCAL".equals(aVar3.abx), aVar2.DS());
                }

                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.library.solder.lib.ext.b.C0493b, com.kwad.library.solder.lib.ext.b
                /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
                public void d(com.kwad.library.solder.lib.b.a aVar) {
                    super.d(aVar);
                    c.d(a.this.getTag(), "update component resource success");
                    com.kwad.components.core.offline.moitor.c.a(a.this.tK(), a.this.getDuration(), SystemClock.elapsedRealtime() - this.aby, a.this.abx);
                }

                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.library.solder.lib.ext.b.C0493b, com.kwad.library.solder.lib.ext.b
                public void a(com.kwad.library.solder.lib.b.a aVar, PluginError pluginError) {
                    super.a(aVar, pluginError);
                    if (aVar.getState() == 1) {
                        com.kwad.components.core.offline.moitor.c.b(a.this.tK(), a.this.getDuration(), pluginError.getCode(), a.this.abx, pluginError.getMessage());
                    }
                    com.kwad.components.core.offline.moitor.a.a(a.this.tK(), a.this.getDuration(), pluginError.getCode(), "cmp_load_error " + pluginError.getMessage(), a.this.abx);
                    c.d(a.this.getTag(), "load component resource failed error: " + pluginError);
                }

                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.library.solder.lib.ext.b.C0493b, com.kwad.library.solder.lib.ext.b
                public void b(com.kwad.library.solder.lib.b.a aVar) {
                    super.b(aVar);
                    c.d(a.this.getTag(), "install component resource start");
                    com.kwad.components.core.offline.moitor.a.b(a.this.tK(), a.this.getDuration(), a.this.abx);
                }

                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.library.solder.lib.ext.b.C0493b, com.kwad.library.solder.lib.ext.b
                /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
                public void a(com.kwad.library.solder.lib.b.a aVar) {
                    super.a(aVar);
                    c.d(a.this.getTag(), "install component resource success");
                    com.kwad.components.core.offline.moitor.a.c(a.this.tK(), a.this.getDuration(), a.this.abx);
                }

                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.library.solder.lib.ext.b.C0493b, com.kwad.library.solder.lib.ext.b
                /* JADX INFO: renamed from: d, reason: merged with bridge method [inline-methods] */
                public void e(com.kwad.library.solder.lib.b.a aVar) {
                    super.e(aVar);
                    this.aby = SystemClock.elapsedRealtime();
                    a.this.abx = aVar.Es() ? "ASSETS" : "NETWORK";
                    c.d(a.this.getTag(), "update component resource start");
                    com.kwad.components.core.offline.moitor.c.d(a.this.tK(), a.this.getDuration(), a.this.abx);
                }

                /* JADX INFO: Access modifiers changed from: private */
                @Override // com.kwad.library.solder.lib.ext.b.C0493b, com.kwad.library.solder.lib.ext.b
                /* JADX INFO: renamed from: e, reason: merged with bridge method [inline-methods] */
                public void c(com.kwad.library.solder.lib.b.a aVar) {
                    super.c(aVar);
                    c.d(a.this.getTag(), "load component resource start");
                    a.this.abx = "LOCAL";
                    com.kwad.components.core.offline.moitor.a.b(a.this.tK(), a.this.getDuration(), aVar.Ej().DW().Ex());
                }
            });
        }
    }

    private com.kwad.library.solder.lib.c.b tH() {
        com.kwad.library.solder.lib.c.b bVar = new com.kwad.library.solder.lib.c.b();
        bVar.aFt = tL();
        bVar.enable = true;
        bVar.aFx = false;
        bVar.aFu = com.kwad.sdk.core.network.idc.a.My().eO(tN());
        bVar.version = tM();
        bVar.aFw = tO();
        if (com.kwad.components.core.a.Ov.booleanValue()) {
            bVar.aEW = tP();
            bVar.aEX = true;
        }
        if (TextUtils.isEmpty(tO()) || TextUtils.isEmpty(tL()) || TextUtils.isEmpty(tM()) || TextUtils.isEmpty(tN())) {
            com.kwad.components.core.offline.moitor.a.a(tK(), getDuration(), PluginError.ERROR_BUILD_REMOTE_PLUGIN_INFO, "buildRemotePlugInfo error", this.abx);
        }
        return bVar;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(Context context, boolean z, ClassLoader classLoader) {
        tI();
        String strTQ = tQ();
        try {
            IOfflineCompo iOfflineCompo = (IOfflineCompo) classLoader.loadClass(strTQ).newInstance();
            c.d(getTag(), "load component instance success: " + iOfflineCompo.getClass().getName() + ", loadFromNet:" + z + ", classLoader:" + classLoader);
            a(context, z, iOfflineCompo);
        } catch (Throwable th) {
            com.kwad.components.core.offline.moitor.a.a(tK(), getDuration(), 4005, "loadClass error", this.abx);
            c.e(getTag(), "loadClass or instance failed: " + strTQ, th);
        }
    }

    private void tI() {
        c.d(getTag(), "init component start cost: " + getDuration());
        com.kwad.components.core.offline.moitor.a.d(tK(), getDuration());
    }

    public final void tJ() {
        c.d(getTag(), "init component success cost: " + getDuration());
        com.kwad.components.core.offline.moitor.a.c(tK(), getDuration(), i.Ec().DW().Ex());
    }

    public final void bg(int i) {
        c.d(getTag(), "init component error time: " + getDuration());
        com.kwad.components.core.offline.moitor.a.a(tK(), getDuration(), 5001, "cmp_init_error, errorCode:" + i, this.abx);
    }
}
