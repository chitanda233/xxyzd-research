package com.sigmob.sdk.base.views;

import android.content.Context;
import android.webkit.JavascriptInterface;
import com.sigmob.sdk.base.models.BaseAdUnit;

/* JADX INFO: loaded from: classes3.dex */
public class ae {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final int f3283a = -1;
    private final Context b;
    private final BaseAdUnit c;
    private final a d;

    public interface a {
        void onApkDownloadProcess();
    }

    public ae(Context context, BaseAdUnit adUnit, a listener) {
        this.b = context;
        this.c = adUnit;
        this.d = listener;
    }

    private int a() {
        BaseAdUnit baseAdUnit = this.c;
        if (baseAdUnit == null) {
            return -1;
        }
        return baseAdUnit.getApkDownloadType();
    }

    @JavascriptInterface
    public int cancelDownloadTask() {
        int iA = a();
        if (iA == -1 || iA == 0) {
            return -1;
        }
        return com.sigmob.sdk.base.common.o.c(this.b, this.c);
    }

    @JavascriptInterface
    public int getApKDownloadProcess() {
        long[] jArrD;
        if (com.sigmob.sdk.base.utils.v.b(this.d)) {
            this.d.onApkDownloadProcess();
        }
        if (this.b == null || this.c == null) {
            return -1;
        }
        if (a() == 0) {
            jArrD = com.sigmob.sdk.base.common.q.a(this.b, this.c.getDownloadId());
        } else {
            jArrD = com.sigmob.sdk.base.common.o.d(this.b, this.c);
        }
        int i = (int) jArrD[2];
        if (i != 1) {
            if (i != 2) {
                if (i != 4) {
                    return i != 8 ? -1 : 100;
                }
                return -2;
            }
            long j = jArrD[0];
            long j2 = jArrD[1];
            if (j2 != 0 && j != 0) {
                return (int) ((j * 100) / j2);
            }
        }
        return 0;
    }

    @JavascriptInterface
    public int getApKDownloadType() {
        return a();
    }

    @JavascriptInterface
    public int pauseDownload() {
        int iA = a();
        if (iA == -1 || iA == 0) {
            return -1;
        }
        return com.sigmob.sdk.base.common.o.a(this.b, this.c);
    }

    @JavascriptInterface
    public int resumeDownload() {
        int iA = a();
        if (iA == -1 || iA == 0) {
            return -1;
        }
        return com.sigmob.sdk.base.common.o.b(this.b, this.c);
    }
}
