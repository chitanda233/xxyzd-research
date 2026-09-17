package com.cmic.gen.sdk.e;

import android.app.KeyguardManager;
import android.content.Context;
import android.os.IBinder;
import java.util.concurrent.LinkedBlockingQueue;

/* JADX INFO: compiled from: CooseaOAID.java */
/* JADX INFO: loaded from: classes2.dex */
public class c extends j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final LinkedBlockingQueue<IBinder> f2101a = new LinkedBlockingQueue<>(1);
    private final KeyguardManager b;

    c(Context context) {
        this.b = (KeyguardManager) context.getSystemService("keyguard");
    }

    @Override // com.cmic.gen.sdk.e.j
    String a() {
        try {
            Object objInvoke = this.b.getClass().getDeclaredMethod("obtainOaid", new Class[0]).invoke(this.b, new Object[0]);
            return objInvoke != null ? objInvoke.toString() : "";
        } catch (Exception e) {
            e.printStackTrace();
            return "";
        }
    }
}
