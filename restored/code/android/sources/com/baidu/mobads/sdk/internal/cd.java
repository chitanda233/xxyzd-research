package com.baidu.mobads.sdk.internal;

import android.os.Handler;
import android.os.Looper;
import android.os.Message;

/* JADX INFO: loaded from: classes.dex */
class cd extends Handler {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ cb f462a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    cd(cb cbVar, Looper looper) {
        super(looper);
        this.f462a = cbVar;
    }

    @Override // android.os.Handler
    public void handleMessage(Message message) {
        String string = message.getData().getString(cb.n);
        bz bzVar = (bz) message.getData().getParcelable(cb.m);
        if (!cb.k.equals(string)) {
            this.f462a.z.a(cb.f459a, "mOnApkDownloadCompleted: download failed, code: " + string);
            this.f462a.a(false);
            if (this.f462a.A) {
                this.f462a.A = false;
                this.f462a.a(false, "Refused to download remote for version...");
                return;
            }
            return;
        }
        bu buVar = new bu(bzVar.e(), this.f462a.y, bzVar);
        try {
            try {
                if (this.f462a.u != cb.t) {
                    this.f462a.a(buVar);
                    buVar.a(cb.f());
                    this.f462a.a(true);
                } else {
                    buVar.a();
                    buVar.a(cb.f());
                    if (cb.p != null) {
                        cb.p.b = bzVar.b();
                    }
                    this.f462a.l();
                    if (this.f462a.A) {
                        this.f462a.A = false;
                        cb cbVar = this.f462a;
                        cbVar.a(cbVar.p(), "load remote file just downloaded");
                    }
                }
            } catch (cb.a e) {
                String str = "download apk file failed: " + e.toString();
                this.f462a.a(false);
                this.f462a.z.a(cb.f459a, str);
            }
        } finally {
            buVar.delete();
        }
    }
}
