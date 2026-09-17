package com.kwad.library.solder.lib;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.library.solder.lib.ext.PluginError;
import com.kwad.sdk.utils.an;
import com.kwad.sdk.utils.y;
import java.io.File;
import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
final class c implements com.kwad.library.solder.lib.a.b {
    private final File aEj;
    private final File aEk;
    private final com.kwad.library.solder.lib.ext.c aEl;
    private final Context mContext;

    c(Context context, com.kwad.library.solder.lib.ext.c cVar) {
        Context applicationContext = context.getApplicationContext();
        this.mContext = applicationContext;
        this.aEl = cVar;
        this.aEj = applicationContext.getDir(cVar.Ey(), 0);
        this.aEk = applicationContext.getCacheDir();
    }

    private boolean i(String str, String str2, boolean z) {
        if (!y.hG(str)) {
            return false;
        }
        if (TextUtils.isEmpty(str2) || TextUtils.equals(str2, an.getFileMD5Digest(str))) {
            return true;
        }
        delete(str);
        return false;
    }

    private static void delete(String str) {
        y.delete(str);
    }

    @Override // com.kwad.library.solder.lib.a.b
    public final void cu(String str) {
        File file = new File(cv(str));
        if (file.exists()) {
            y.V(file);
        }
    }

    @Override // com.kwad.library.solder.lib.a.b
    public final void F(String str, String str2) {
        File file = new File(G(str, str2));
        if (file.exists()) {
            y.V(file);
        }
    }

    @Override // com.kwad.library.solder.lib.a.b
    public final void DU() throws IOException {
        if (this.aEj.getFreeSpace() < 10000000) {
            throw new IOException("No enough capacity.");
        }
    }

    @Override // com.kwad.library.solder.lib.a.b
    public final File e(String str, boolean z) {
        String md5;
        if (str == null || (md5 = com.kwad.library.solder.lib.d.b.getMD5(str)) == null) {
            return null;
        }
        if (z) {
            StringBuilder sb = new StringBuilder();
            sb.append(md5);
            if (this.aEl.EC() != null) {
                sb.append(this.aEl.EC());
            }
            File file = new File(this.aEk, sb.toString());
            if (file.exists() || file.createNewFile()) {
                return file;
            }
            return null;
        }
        return File.createTempFile(md5 + System.currentTimeMillis(), this.aEl.EC(), this.aEk);
    }

    private String DV() {
        return this.aEj.getAbsolutePath();
    }

    @Override // com.kwad.library.solder.lib.a.b
    public final String cv(String str) {
        return DV() + File.separator + str;
    }

    private String G(String str, String str2) {
        return DV() + File.separator + str + File.separator + str2;
    }

    @Override // com.kwad.library.solder.lib.a.b
    public final String H(String str, String str2) {
        return DV() + File.separator + str + File.separator + str2 + File.separator + this.aEl.ED();
    }

    private String a(com.kwad.library.solder.lib.a.a aVar) {
        return H(aVar.getId(), aVar.getVersion());
    }

    @Override // com.kwad.library.solder.lib.a.b
    public final boolean a(String str, String str2, String str3) {
        if (this.aEl.EE()) {
            return false;
        }
        return i(H(str, str2), str3, true);
    }

    @Override // com.kwad.library.solder.lib.a.b
    public final String b(com.kwad.library.solder.lib.a.a aVar) throws PluginError.InstallError {
        String strA = a(aVar);
        if (TextUtils.isEmpty(strA)) {
            throw new PluginError.InstallError("Can not get install path.", 3006);
        }
        aVar.getId();
        File file = new File(strA);
        if (file.exists() && !this.aEl.EE() && i(file.getAbsolutePath(), aVar.Ei(), true)) {
            return strA;
        }
        String strEh = aVar.Eh();
        aVar.getId();
        File file2 = new File(strEh);
        if (!file2.exists()) {
            throw new PluginError.InstallError("Plugin file not exist.", 3001);
        }
        aVar.getId();
        if (!i(strEh, aVar.Ei(), true)) {
            aVar.Ei();
            throw new PluginError.InstallError("check plugin md5 fail:" + aVar.Ei() + " " + strEh, 3003);
        }
        if (file2.renameTo(file)) {
            aVar.getId();
            return strA;
        }
        try {
            DU();
            try {
                y.h(file2, file);
                y.V(file2);
                return strA;
            } catch (Throwable th) {
                a.e("PluginInstallerImpl", th);
                throw new PluginError.InstallError(th, 3004);
            }
        } catch (Throwable th2) {
            a.e("PluginInstallerImpl", th2);
            throw new PluginError.InstallError(th2, 3005);
        }
    }
}
