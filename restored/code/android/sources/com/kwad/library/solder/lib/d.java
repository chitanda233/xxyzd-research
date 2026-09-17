package com.kwad.library.solder.lib;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.library.solder.lib.ext.PluginError;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.y;
import java.io.File;
import java.util.List;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
final class d implements com.kwad.library.solder.lib.a.c {
    private final ConcurrentHashMap<String, com.kwad.library.solder.lib.a.a> aEm = new ConcurrentHashMap<>();
    private final Context mContext;

    d(Context context) {
        this.mContext = context.getApplicationContext();
    }

    @Override // com.kwad.library.solder.lib.a.c
    public final void g(com.kwad.library.solder.lib.a.e eVar) {
        eVar.En();
        eVar.cC("Load");
        c(eVar);
        if (eVar.isCanceled()) {
            f(eVar);
            return;
        }
        com.kwad.library.solder.lib.a.a aVar = this.aEm.get(eVar.En());
        if (aVar != null && aVar.isLoaded()) {
            eVar.c(aVar);
            eVar.En();
            aVar.Eh();
            a(eVar, aVar);
            return;
        }
        com.kwad.library.solder.lib.c.b bVarEv = eVar.Ev();
        if (bVarEv == null) {
            b(eVar, new PluginError.LoadError("not pluginInfo", PluginError.ERROR_UPD_REQUEST));
            return;
        }
        List<com.kwad.library.solder.lib.c.a> listEw = eVar.Ew();
        com.kwad.library.solder.lib.c.a aVar2 = null;
        if (listEw != null && !listEw.isEmpty()) {
            for (com.kwad.library.solder.lib.c.a aVar3 : listEw) {
                if (eVar.getVersion().equals(aVar3.version)) {
                    aVar2 = aVar3;
                } else {
                    eVar.Ej().DZ().F(eVar.En(), aVar3.version);
                }
            }
        }
        if (aVar2 == null) {
            if (!aq.isWifiConnected(this.mContext) && (bVarEv.aFx || (bVarEv.aFy && eVar.Ep() > 0))) {
                b(eVar, new PluginError.NotWifiDownloadError("It can be downloaded only on WiFi", PluginError.ERROR_UPD_NOT_WIFI_DOWNLOAD));
                return;
            }
            try {
                if (!eVar.Ej().DY().k(eVar)) {
                    return;
                }
            } catch (Throwable th) {
                b(eVar, new PluginError.UpdateError(th, PluginError.ERROR_UPD_REQUEST));
                return;
            }
        } else {
            String strH = eVar.Ej().DZ().H(aVar2.aFt, aVar2.version);
            eVar.cD(strH);
            eVar.cE(strH);
            eVar.cW(2);
            eVar.cz(aVar2.version);
        }
        if (eVar.getState() == 2 || eVar.getState() == 3 || eVar.getState() == 4) {
            String strEq = eVar.Eq();
            eVar.En();
            if (TextUtils.isEmpty(strEq)) {
                b(eVar, new PluginError.LoadError("path not found", PluginError.ERROR_UPD_FILE_NOT_FOUND));
                return;
            }
            if (eVar.isCanceled()) {
                f(eVar);
                return;
            }
            try {
                com.kwad.library.solder.lib.a.a aVarH = h(eVar);
                eVar.c(aVarH);
                new StringBuilder("load plugin success pluginId: ").append(eVar.En()).append(", path: ");
                a(eVar, aVarH);
                return;
            } catch (PluginError.InstallError e) {
                e = e;
                b(eVar, e);
                return;
            } catch (PluginError.LoadError e2) {
                e = e2;
                b(eVar, e);
                return;
            } catch (Throwable th2) {
                a.e("PluginLoaderImpl", "load plugin failed, path = " + strEq, th2);
                b(eVar, new PluginError.InstallError("load or install plugin failed:" + th2.getMessage(), 4004));
                return;
            }
        }
        b(eVar, new PluginError.InstallError("state exception", 2002));
    }

    private com.kwad.library.solder.lib.a.a h(com.kwad.library.solder.lib.a.e eVar) throws PluginError.LoadError {
        b(eVar);
        com.kwad.library.solder.lib.a.a aVarA = eVar.cF(eVar.Eq()).a(eVar.Ev());
        String strEh = aVarA.Eh();
        File file = new File(strEh);
        eVar.En();
        com.kwad.library.solder.lib.a.d dVarEj = eVar.Ej();
        if (!file.exists()) {
            throw new PluginError.LoadError("Apk file not exist.", 3001);
        }
        String strEn = eVar.En();
        String version = eVar.getVersion();
        com.kwad.library.solder.lib.a.a aVarCw = cw(strEn);
        if (aVarCw != null) {
            a(eVar);
            return aVarCw;
        }
        aVarA.cA(strEn);
        aVarA.cz(version);
        if (dVarEj.DZ().a(strEn, version, eVar.Eu())) {
            String strH = dVarEj.DZ().H(strEn, version);
            if (y.hF(strH)) {
                aVarA.cB(strH);
                aVarA.q(this.mContext, strH);
                a(strEn, aVarA);
                a(eVar);
                return aVarA;
            }
        }
        String strB = dVarEj.DZ().b(aVarA);
        aVarA.cB(strB);
        aVarA.q(this.mContext, strB);
        a(strEn, aVarA);
        if (strEh.endsWith(dVarEj.DW().EC())) {
            y.delete(strEh);
        }
        a(eVar);
        return aVarA;
    }

    @Override // com.kwad.library.solder.lib.a.c
    public final synchronized com.kwad.library.solder.lib.a.a cw(String str) {
        com.kwad.library.solder.lib.a.a aVar = this.aEm.get(str);
        if (aVar == null || aVar.isLoaded()) {
            return aVar;
        }
        return null;
    }

    private synchronized void a(String str, com.kwad.library.solder.lib.a.a aVar) {
        if (aVar != null) {
            if (aVar.isLoaded()) {
                this.aEm.put(str, aVar);
            }
        }
    }

    private static void c(com.kwad.library.solder.lib.a.e eVar) {
        eVar.getState();
        eVar.Ej().Ea().q(eVar);
    }

    private static void b(com.kwad.library.solder.lib.a.e eVar) {
        eVar.getState();
        eVar.cW(7);
        eVar.Ej().Ea().r(eVar);
    }

    private static void a(com.kwad.library.solder.lib.a.e eVar) {
        eVar.getState();
        eVar.cW(8);
        eVar.Ej().Ea().a(eVar);
    }

    private static void b(com.kwad.library.solder.lib.a.e eVar, PluginError pluginError) {
        eVar.getState();
        eVar.cW(6);
        eVar.q(pluginError);
        eVar.Ej().Ea().c(eVar, pluginError);
    }

    private static void f(com.kwad.library.solder.lib.a.e eVar) {
        eVar.getState();
        eVar.cW(0);
        eVar.Ej().Ea().n(eVar);
    }

    private static void a(com.kwad.library.solder.lib.a.e eVar, com.kwad.library.solder.lib.a.a aVar) {
        eVar.getState();
        eVar.cW(5);
        eVar.Ej().Ea().b(eVar, aVar);
    }
}
