package com.unicom.online.account.kernel;

import android.content.Context;
import java.net.InetAddress;
import java.util.ArrayList;
import java.util.Random;

/* JADX INFO: loaded from: classes4.dex */
public final class bo implements Runnable {
    public final /* synthetic */ bp b;

    public bo(bp bpVar) {
        this.b = bpVar;
    }

    @Override // java.lang.Runnable
    public final void run() {
        try {
            System.currentTimeMillis();
            ao.o.size();
            for (int i = 0; i < ao.o.size(); i++) {
                t tVar = (t) ao.o.get(i);
                InetAddress[] allByName = InetAddress.getAllByName(tVar.b);
                if (allByName != null && allByName.length > 0) {
                    bp bpVar = this.b;
                    int length = allByName.length;
                    bpVar.getClass();
                    tVar.d = allByName[Math.abs(new Random().nextInt() % length)].getHostAddress();
                    tVar.e = System.currentTimeMillis() + 259200000;
                }
            }
            Context contextB = bp.b();
            boolean z = ap.b;
            bf.b(contextB, new ArrayList(ao.o));
            System.currentTimeMillis();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
