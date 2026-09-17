package com.sigmob.sdk.base.common;

import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.network.SigmobRequestQueue;
import com.czhj.volley.toolbox.FileDownloader;

/* JADX INFO: loaded from: classes3.dex */
public class t {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static FileDownloader f3200a;

    public static FileDownloader a() {
        if (f3200a == null) {
            synchronized (t.class) {
                SigmobRequestQueue downloadRequestQueue = Networking.getDownloadRequestQueue();
                if (f3200a == null && downloadRequestQueue != null) {
                    f3200a = new FileDownloader(downloadRequestQueue, 3);
                }
            }
        }
        return f3200a;
    }
}
