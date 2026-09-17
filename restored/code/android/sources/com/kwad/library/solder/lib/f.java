package com.kwad.library.solder.lib;

import android.content.Context;
import android.text.TextUtils;
import android.util.Log;
import com.kwad.library.solder.lib.ext.PluginError;
import com.kwad.sdk.utils.an;
import com.kwad.sdk.utils.y;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
final class f implements com.kwad.library.solder.lib.a.f {
    private com.kwad.library.solder.lib.a.f.a aEy;
    private final Context mContext;

    f(Context context) {
        this.mContext = context.getApplicationContext();
    }

    @Override // com.kwad.library.solder.lib.a.f
    public final boolean k(com.kwad.library.solder.lib.a.e eVar) {
        eVar.En();
        eVar.cC("Update");
        e(eVar);
        if (eVar.Eo()) {
            eVar.Ej().DZ().cu(eVar.En());
        }
        if (eVar.isCanceled()) {
            f(eVar);
            return false;
        }
        try {
            eVar.Ej().DZ().DU();
            if (eVar.Es()) {
                try {
                    File fileE = eVar.Ej().DZ().e(eVar.Et(), false);
                    if (eVar.isCanceled()) {
                        f(eVar);
                        return false;
                    }
                    try {
                        y.a(this.mContext, eVar.Et(), fileE);
                        eVar.cD(fileE.getAbsolutePath());
                        eVar.cW(3);
                        l(eVar);
                    } catch (Throwable th) {
                        a.e("PluginUpdaterImpl", th);
                        a(eVar, new PluginError.UpdateError(th, PluginError.ERROR_UPD_EXTRACT));
                    }
                } catch (Throwable th2) {
                    th2.getLocalizedMessage();
                    a(eVar, new PluginError.UpdateError(th2, 2003));
                    return false;
                }
            } else {
                eVar.En();
                eVar.getDownloadUrl();
                try {
                    File fileE2 = eVar.Ej().DZ().e(eVar.getDownloadUrl(), eVar.Ej().DW().EF());
                    if (eVar.Eu() != null && fileE2.exists() && TextUtils.equals(an.getFileMD5Digest(fileE2), eVar.Eu())) {
                        eVar.cD(fileE2.getAbsolutePath());
                        eVar.cW(4);
                        l(eVar);
                        return true;
                    }
                    try {
                        a(eVar, fileE2);
                        eVar.cD(fileE2.getAbsolutePath());
                        eVar.cW(4);
                        l(eVar);
                    } catch (PluginError.CancelError unused) {
                        f(eVar);
                        return false;
                    } catch (PluginError.UpdateError e) {
                        a.e("PluginUpdaterImpl", "Download plugin fail, error = " + e.getLocalizedMessage());
                        eVar.q(e);
                        a(eVar, e);
                        return false;
                    }
                } catch (Throwable th3) {
                    a.e("PluginUpdaterImpl", "Can not get temp file, error = " + th3.getLocalizedMessage());
                    a(eVar, new PluginError.UpdateError(th3, 2003));
                    return false;
                }
            }
            return true;
        } catch (Throwable th4) {
            a.e("PluginUpdaterImpl", th4);
            a(eVar, new PluginError.UpdateError(th4, PluginError.ERROR_UPD_CAPACITY));
            return false;
        }
    }

    @Override // com.kwad.library.solder.lib.a.f
    public final com.kwad.library.solder.lib.a.f a(com.kwad.library.solder.lib.a.f.a aVar) {
        this.aEy = aVar;
        return this;
    }

    private static void e(com.kwad.library.solder.lib.a.e eVar) {
        eVar.getState();
        eVar.Ej().Ea().o(eVar);
    }

    private static void f(com.kwad.library.solder.lib.a.e eVar) {
        eVar.getState();
        eVar.cW(0);
        eVar.Ej().Ea().n(eVar);
    }

    private static void a(com.kwad.library.solder.lib.a.e eVar, PluginError.UpdateError updateError) {
        eVar.getState();
        eVar.cW(1);
        eVar.q(updateError);
        eVar.Ej().Ea().c(eVar, updateError);
    }

    private static void l(com.kwad.library.solder.lib.a.e eVar) {
        eVar.getState();
        eVar.Ej().Ea().p(eVar);
    }

    private void a(com.kwad.library.solder.lib.a.e eVar, File file) throws PluginError.UpdateError {
        long jCurrentTimeMillis = System.currentTimeMillis();
        Log.d("PluginUpdaterImpl", "start download pluginId: " + eVar.En());
        com.kwad.library.solder.lib.a.f.a aVar = this.aEy;
        if (aVar == null) {
            throw new PluginError.UpdateError("update ", PluginError.ERROR_UPD_NO_DOWNLOADER);
        }
        aVar.a(eVar, file);
        Log.i("PluginUpdaterImpl", "finish download pluginId: " + eVar.En() + " cost:" + (System.currentTimeMillis() - jCurrentTimeMillis));
    }
}
