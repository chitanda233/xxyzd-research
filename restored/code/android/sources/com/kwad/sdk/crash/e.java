package com.kwad.sdk.crash;

import android.content.Context;
import android.os.SystemClock;
import com.kwad.sdk.crash.model.message.ExceptionMessage;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private com.kwad.sdk.crash.b.b beg;
    private c beh;
    private long bei;

    /* synthetic */ e(byte b) {
        this();
    }

    public final void b(int i, ExceptionMessage exceptionMessage) {
        f fVarQj = this.beh.Qj();
        if (fVarQj != null) {
            fVarQj.a(i, exceptionMessage);
        }
    }

    static class a {
        private static final e bej = new e(0);
    }

    private e() {
        this.beg = new com.kwad.sdk.crash.b.b();
        this.beh = new c.a().Ql();
    }

    public static e Qm() {
        return a.bej;
    }

    public final String[] Qn() {
        return this.beg.Qz();
    }

    public final String[] Qo() {
        return this.beg.Qo();
    }

    public final String getAppId() {
        return this.beh.bdF.mAppId;
    }

    public final String Qp() {
        return this.beh.bdE.beK;
    }

    public final String getSdkVersion() {
        return this.beh.bdE.mSdkVersion;
    }

    public final int Qq() {
        return this.beh.bdE.beO;
    }

    public final void a(c cVar) {
        this.beh = cVar;
        this.bei = SystemClock.elapsedRealtime();
        this.beg.a(cVar.bdH, cVar.bdI);
    }

    public final Context getContext() {
        return this.beh.context;
    }

    public final c Qr() {
        return this.beh;
    }

    public final h Qs() {
        return this.beh.bdG;
    }

    public final long Qt() {
        return SystemClock.elapsedRealtime() - this.bei;
    }

    public final boolean isDebug() {
        return this.beh.isDebugMode();
    }
}
