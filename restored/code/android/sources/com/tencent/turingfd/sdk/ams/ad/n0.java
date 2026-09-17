package com.tencent.turingfd.sdk.ams.ad;

import com.bykv.vk.component.ttvideo.player.C;
import java.io.ByteArrayOutputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.util.concurrent.TimeoutException;

/* JADX INFO: loaded from: classes4.dex */
public final class n0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Object f3948a;
    public final Object b;
    public Process c;
    public final DataOutputStream d;
    public k0 e;
    public k0 f;
    public final ByteArrayOutputStream g;
    public final ByteArrayOutputStream h;

    public n0() throws IOException {
        Object obj = new Object();
        this.f3948a = obj;
        this.b = new Object();
        this.g = new ByteArrayOutputStream();
        this.h = new ByteArrayOutputStream();
        this.c = Runtime.getRuntime().exec("sh");
        synchronized (obj) {
            obj.wait(10L);
        }
        try {
            this.c.exitValue();
            throw new IOException();
        } catch (Exception unused) {
            this.d = new DataOutputStream(this.c.getOutputStream());
            this.e = new k0(this, com.kuaishou.weapon.p0.t.g, this.c.getInputStream(), this.g);
            this.f = new k0(this, "e", this.c.getErrorStream(), this.h);
            synchronized (this.f3948a) {
                this.f3948a.wait(10L);
                this.e.start();
                this.f.start();
            }
        }
    }

    public final l0 a(m0 m0Var, long j) {
        boolean z;
        synchronized (this.f3948a) {
            synchronized (this.b) {
                z = new String(this.g.toByteArray()).lastIndexOf(":RET=") == -1;
            }
            if (z) {
                this.f3948a.wait(j);
            }
        }
        synchronized (this.b) {
            byte[] byteArray = this.g.toByteArray();
            byte[] byteArray2 = this.h.toByteArray();
            String str = new String(byteArray);
            String str2 = new String(byteArray2);
            if (str.lastIndexOf(":RET=") == -1) {
                return null;
            }
            this.g.reset();
            this.h.reset();
            if (str.lastIndexOf(":RET=0") != -1) {
                return new l0(str.substring(0, str.lastIndexOf(":RET=")), str2);
            }
            if (str.lastIndexOf(":RET=EOF") == -1) {
                str2.lastIndexOf(":RET=EOF");
            }
            return new l0(str.substring(0, str.lastIndexOf(":RET=")), str2);
        }
    }

    public final synchronized l0 b() {
        return a(new m0("export LD_LIBRARY_PATH=/vendor/lib:/system/lib", "export LD_LIBRARY_PATH=/vendor/lib:/system/lib", 5000L));
    }

    public final void finalize() throws Throwable {
        try {
            a();
        } catch (Throwable unused) {
        }
        super.finalize();
    }

    public final void a() {
        try {
            this.d.write("exit\n".getBytes());
            this.d.flush();
            this.c.wait(100L);
        } catch (Exception unused) {
        }
        k0 k0Var = this.e;
        if (k0Var != null) {
            k0Var.interrupt();
            this.e = null;
        }
        k0 k0Var2 = this.f;
        if (k0Var2 != null) {
            k0Var2.interrupt();
            this.f = null;
        }
        Process process = this.c;
        if (process != null) {
            try {
                process.destroy();
            } catch (Throwable unused2) {
            }
            this.c = null;
        }
    }

    public final synchronized l0 a(m0 m0Var) {
        String str;
        l0 l0VarA;
        String str2 = m0Var.f3946a;
        if (str2 != null && str2.length() > 0 && (str = m0Var.b) != null && str.length() > 0 && m0Var.c >= 0) {
            synchronized (this.b) {
                this.g.reset();
                this.h.reset();
            }
            this.d.write((m0Var.b + "\n").getBytes());
            this.d.flush();
            synchronized (this.f3948a) {
                this.f3948a.wait(10L);
            }
            this.d.writeBytes("echo :RET=$?\n");
            this.d.flush();
            long jNanoTime = System.nanoTime();
            long jNanoTime2 = 0;
            do {
                long j = m0Var.c;
                if (j != 0) {
                    jNanoTime2 = j - ((System.nanoTime() - jNanoTime) / C.MICROS_PER_SECOND);
                    if (jNanoTime2 <= 0) {
                        throw new TimeoutException("t");
                    }
                }
                l0VarA = a(m0Var, jNanoTime2);
            } while (l0VarA == null);
        } else {
            throw new IllegalArgumentException(com.kuaishou.weapon.p0.t.c);
        }
        return l0VarA;
    }
}
