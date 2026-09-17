package com.unicom.online.account.kernel;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.Network;
import android.net.NetworkRequest;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Timer;

/* JADX INFO: loaded from: classes4.dex */
public final class ab {
    public Network b = null;
    public x c = null;
    public ConnectivityManager d = null;
    public final ArrayList e = new ArrayList();
    public Timer f = null;

    public final void b(Context context, z zVar) {
        synchronized (this) {
            Network network = this.b;
            if (network != null) {
                zVar.b(network, true);
                return;
            }
            b(zVar);
            if (this.c == null || this.e.size() < 2) {
                try {
                    try {
                        this.d = (ConnectivityManager) context.getSystemService("connectivity");
                        NetworkRequest.Builder builder = new NetworkRequest.Builder();
                        builder.addTransportType(0);
                        builder.addCapability(12);
                        NetworkRequest networkRequestBuild = builder.build();
                        this.c = new x(this);
                        int i = ao.u;
                        if (i > 2000) {
                            i = 2000;
                        }
                        Thread.currentThread().getName();
                        System.currentTimeMillis();
                        this.d.requestNetwork(networkRequestBuild, this.c, i);
                    } catch (Exception e) {
                        as.b(e);
                        b(false, (Network) null);
                    }
                } catch (Exception e2) {
                    as.b(e2);
                    b(false, (Network) null);
                }
            }
        }
    }

    public final synchronized void b() {
        x xVar;
        try {
            Timer timer = this.f;
            if (timer != null) {
                timer.cancel();
                this.f = null;
            }
            ConnectivityManager connectivityManager = this.d;
            if (connectivityManager != null && (xVar = this.c) != null) {
                try {
                    connectivityManager.unregisterNetworkCallback(xVar);
                } catch (IllegalArgumentException e) {
                    e.getMessage();
                }
            }
            this.d = null;
            this.c = null;
            this.b = null;
            ArrayList arrayList = this.e;
            if (arrayList != null) {
                arrayList.clear();
            }
        } catch (Exception e2) {
            as.b(e2);
        }
    }

    public final synchronized void b(z zVar) {
        try {
            this.e.add(zVar);
        } catch (Exception e) {
            as.b(e);
        }
    }

    public final synchronized void b(boolean z, Network network) {
        try {
            Timer timer = this.f;
            if (timer != null) {
                timer.cancel();
                this.f = null;
            }
            Iterator it = this.e.iterator();
            while (it.hasNext()) {
                ((z) it.next()).b(network, z);
            }
            this.e.clear();
        } catch (Exception e) {
            as.b(e);
        }
    }
}
