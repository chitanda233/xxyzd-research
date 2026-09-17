package com.tencent.turingfd.sdk.ams.ad;

import java.io.Closeable;

/* JADX INFO: loaded from: classes4.dex */
public abstract class GalacticCore {
    public static void a(Closeable closeable) {
        if (closeable != null) {
            try {
                closeable.close();
            } catch (Throwable unused) {
            }
        }
    }
}
