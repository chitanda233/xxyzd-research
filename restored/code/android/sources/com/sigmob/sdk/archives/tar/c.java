package com.sigmob.sdk.archives.tar;

/* JADX INFO: loaded from: classes2.dex */
public class c implements e {
    private boolean b;

    public c(byte[] headerBuf) {
        this.b = f.a(headerBuf, e.E);
    }

    public boolean a() {
        return this.b;
    }
}
