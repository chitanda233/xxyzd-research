package com.tencent.turingfd.sdk.ams.ad;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;

/* JADX INFO: loaded from: classes4.dex */
public final class k0 extends Thread {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final InputStream f3942a;
    public final ByteArrayOutputStream b;
    public final /* synthetic */ n0 c;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public k0(n0 n0Var, String str, InputStream inputStream, ByteArrayOutputStream byteArrayOutputStream) {
        super(str);
        this.c = n0Var;
        this.f3942a = inputStream;
        this.b = byteArrayOutputStream;
    }

    @Override // java.lang.Thread, java.lang.Runnable
    public final void run() {
        try {
            byte[] bArr = new byte[1024];
            while (true) {
                int i = this.f3942a.read(bArr);
                if (i < 0) {
                    synchronized (this.c.b) {
                        this.b.write(":RET=EOF".getBytes());
                        this.b.flush();
                    }
                    synchronized (this.c.f3948a) {
                        this.c.f3948a.notifyAll();
                    }
                    return;
                }
                if (i > 0) {
                    synchronized (this.c.b) {
                        this.b.write(bArr, 0, i);
                        this.b.flush();
                    }
                    synchronized (this.c.f3948a) {
                        this.c.f3948a.notifyAll();
                    }
                }
            }
        } catch (Exception unused) {
        }
    }
}
