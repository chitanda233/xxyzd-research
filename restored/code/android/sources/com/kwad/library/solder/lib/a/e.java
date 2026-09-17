package com.kwad.library.solder.lib.a;

import android.text.TextUtils;
import com.kwad.library.solder.lib.a.a;
import java.io.File;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public abstract class e<P extends a> {
    protected String aDV;
    protected int aEO;
    protected String aEQ;
    protected String aER;
    protected boolean aES;
    protected P aET;
    protected com.kwad.library.solder.lib.ext.b aEU;
    protected Throwable aEV;
    protected String aEW;
    protected boolean aEX;
    protected long aEY;
    protected String aEZ;
    protected d aEv;
    protected List<com.kwad.library.solder.lib.c.a> aFa;
    protected com.kwad.library.solder.lib.c.b aFb;
    protected String mDownloadUrl;
    protected String mVersion;
    protected int mState = -1;
    protected int aEN = 0;
    private final byte[] aEK = new byte[0];
    protected StringBuffer aEP = new StringBuffer(String.valueOf(this.mState));

    public abstract P cF(String str);

    public e(com.kwad.library.solder.lib.c.b bVar) {
        this.aFb = bVar;
        this.aDV = bVar.aFt;
        this.mVersion = bVar.version;
        this.aEZ = bVar.aFw;
        this.aEX = bVar.aEX;
        this.aEW = bVar.aEW;
        this.aEY = bVar.aFv;
        this.mDownloadUrl = bVar.aFu;
    }

    public final String getVersion() {
        return this.mVersion;
    }

    public final void cz(String str) {
        this.mVersion = str;
    }

    public final e a(d dVar) {
        this.aEv = dVar;
        return this;
    }

    public final d Ej() {
        return this.aEv;
    }

    public final int getState() {
        int i;
        synchronized (this.aEK) {
            i = this.mState;
        }
        return i;
    }

    public final String Ek() {
        return this.aEP.toString();
    }

    public final e cW(int i) {
        synchronized (this.aEK) {
            this.mState = i;
        }
        return cC(String.valueOf(i));
    }

    public final void cancel() {
        synchronized (this.aEK) {
            cW(0);
        }
    }

    public final boolean isCanceled() {
        return this.mState == 0;
    }

    public final e cC(String str) {
        if (!TextUtils.isEmpty(str)) {
            this.aEP.append(" --> ").append(str);
        }
        return this;
    }

    public final Throwable El() {
        return this.aEV;
    }

    public final e q(Throwable th) {
        this.aEV = th;
        return cC(th.getLocalizedMessage());
    }

    public final boolean Em() {
        cW(-1);
        this.aFa = null;
        int i = this.aEN + 1;
        this.aEN = i;
        return i <= this.aEO;
    }

    public final void cX(int i) {
        if (i > 0) {
            this.aEO = i;
        }
    }

    public final String En() {
        return this.aDV;
    }

    public final boolean Eo() {
        return this.aES;
    }

    public final int Ep() {
        return this.aEN;
    }

    public final String Eq() {
        if (!TextUtils.isEmpty(this.aEQ)) {
            return this.aEQ;
        }
        return this.aER;
    }

    public final void cD(String str) {
        this.aEQ = str;
    }

    public final void cE(String str) {
        this.aER = str;
    }

    public final void c(P p) {
        this.aET = p;
    }

    public final com.kwad.library.solder.lib.ext.b Er() {
        return this.aEU;
    }

    public final void a(com.kwad.library.solder.lib.ext.b bVar) {
        this.aEU = bVar;
    }

    public final boolean Es() {
        return this.aEX;
    }

    public final String Et() {
        return this.aEW;
    }

    public final String Eu() {
        return this.aEZ;
    }

    public final String getDownloadUrl() {
        return this.mDownloadUrl;
    }

    public final com.kwad.library.solder.lib.c.b Ev() {
        return this.aFb;
    }

    public final List<com.kwad.library.solder.lib.c.a> Ew() {
        String strEn = En();
        if (!TextUtils.isEmpty(strEn) && this.aFa == null) {
            this.aFa = b(strEn, getVersion(), Eu());
        }
        return this.aFa;
    }

    private List<com.kwad.library.solder.lib.c.a> b(String str, String str2, String str3) {
        String[] list;
        ArrayList arrayList = new ArrayList();
        if (!TextUtils.isEmpty(str) && !TextUtils.isEmpty(str2)) {
            File file = new File(this.aEv.DZ().cv(str));
            if (file.exists() && (list = file.list()) != null && list.length != 0) {
                for (String str4 : list) {
                    if (!TextUtils.isEmpty(str4) && !TextUtils.isEmpty(str2) && str2.equals(str4)) {
                        if (this.aEv.DZ().a(str, str4, str3)) {
                            com.kwad.library.solder.lib.c.a aVar = new com.kwad.library.solder.lib.c.a();
                            aVar.aFt = str;
                            aVar.version = str4;
                            aVar.uf = true;
                            arrayList.add(aVar);
                        } else {
                            this.aEv.DZ().F(str, str4);
                        }
                    } else {
                        this.aEv.DZ().F(str, str4);
                    }
                }
                Collections.sort(arrayList);
            }
        }
        return arrayList;
    }

    public String toString() {
        return "PluginRequest{mId='" + this.aDV + "'}";
    }
}
